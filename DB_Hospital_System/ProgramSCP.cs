using System;
using System.Drawing;
using System.IO;
using System.Net;
using Renci.SshNet;

class SCPOperation {
    #region 声明一个ScpClient类型的变量
    private ScpClient ssh;

    /// <summary>
    /// SCP连接状态
    /// </summary>
    public bool Connected { get { return ssh.IsConnected; } }
    #endregion

    # region 构造方法
    /// <summary>
    /// 构造方法
    /// </summary>
    /// <param name="ip">IP</param>
    /// <param name="port">端口</param>
    /// <param name="user">用户名</param>
    /// <param name="pwd">密码</param>
    public SCPOperation(string ip, string port, string user, string pwd) {
        ssh = new ScpClient(ip, Int32.Parse(port), user, pwd);
    }
    # endregion

    # region 连接SCP
    /// <summary>
    /// 连接SCP
    /// </summary>
    /// <returns>true成功</returns>
    public bool Connect() {
        try {
            if (!Connected) {
                ssh.Connect();
            }
            return true;
        }
        catch (Exception ex) {
            throw new Exception(string.Format("连接SFTP失败，原因：{0}", ex.Message));
            //Console.WriteLine(string.Format("连接SFTP失败，原因：{0}", ex.Message));
        }
    }
    # endregion

    # region 断开SCP
    /// <summary>
    /// 断开SCP
    /// </summary> 
    /// <returns>true成功</returns>
    public bool Disconnect() {
        try {
            if (ssh != null && Connected) {
                ssh.Disconnect();
            }
            return true;
        }
        catch (Exception ex) {
            throw new Exception(string.Format("断开SFTP失败，原因：{0}", ex.Message));
        }
    }
    # endregion

    # region SFTP上传文件
    /// <summary>
    /// SCP上传文件
    /// </summary>
    /// <param name="localPath">本地路径</param>
    /// <param name="remotePath">远程路径</param>
    public int Put(string localPath, string remotePath) {
        try {
            FileInfo file = new FileInfo(localPath);
            Connect();
            ssh.Upload(file, remotePath);
            Disconnect();
            return 1;
        }
        catch (Exception ex) {
            throw new Exception(string.Format("SFTP文件上传失败，原因：{0}", ex.Message));
        }
    }
    # endregion

    # region SFTP获取文件
    /// <summary>
    /// SCP获取文件
    /// </summary>
    /// <param name="remotePath">远程路径</param>
    /// <param name="localPath">本地路径</param>
    public void Get(string remotePath, string localPath) {
        try {
            Connect();
            DirectoryInfo localdir = new DirectoryInfo(localPath);
            ssh.Download(remotePath, localdir);
            Disconnect();
        }
        catch (Exception ex) {
            throw new Exception(string.Format("SFTP文件获取失败，原因：{0}", ex.Message));
        }

    }
    #endregion

}

class ImageOperation {

    # region 从给定的本地路径上传图片
    /// <summary>
    /// 上传图片
    /// </summary>
    /// <param name="localPath">本地路径</param>
    /// <param name="filename">文件名</param>
    /// <param name="remotePath">目标路径</param>
    public void update_img(string fullpath, string filename, string remotePath) {

        if (HasChinese(filename)) {
            throw new Exception(string.Format("错误！文件名不能含有中文！"));
        }

        string ftpIP = "101.133.237.83";
        string ftpUSER = "root";
        string ftpPSD = "lsl123456";
        string ftpPORT = "22";
        remotePath = "/home/shinoai/test/http" + remotePath;

        SCPOperation test = new SCPOperation(ftpIP, ftpPORT, ftpUSER, ftpPSD);
        test.Put(fullpath, remotePath);
    }

    # endregion

    # region 将图片缩放到适合容器大小
    /// <summary>
    /// 缩放图片
    /// </summary>
    /// <param name="bitmap">图片</param>
    /// <param name="destHeight">容器高度</param>
    /// <param name="destWidth">容器宽度</param>
    public Bitmap ZoomImage(Bitmap bitmap, int destHeight, int destWidth) {
        try {
            System.Drawing.Image sourImage = bitmap;
            //按比例缩放           
            int sourWidth = sourImage.Width;
            int sourHeight = sourImage.Height;

            int sourp = sourHeight / sourWidth;
            int destp = destHeight / destWidth;

            int start_width = 0, start_height = 0;
            int end_width = 0, end_height = 0;

            //根据数学计算获得绘制起点和终点
            if (sourp > destp) {
                start_height = (sourHeight - (destHeight * sourWidth / destWidth)) / 2;
                start_width = 0;
                end_height = (destHeight * sourWidth / destWidth);
                end_width = sourHeight;
            }
            else {
                start_width = (sourWidth - (destWidth * sourHeight / destHeight)) / 2;
                start_height = 0;
                end_width = (destWidth * sourHeight / destHeight);
                end_height = sourHeight;
            }
            Bitmap destBitmap = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage(destBitmap);
            g.Clear(Color.Transparent);
            //设置画布的描绘质量         
            g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            g.DrawImage(sourImage, new Rectangle(0, 0, destWidth, destHeight), start_width, start_height, end_width, end_height, GraphicsUnit.Pixel);
            g.Dispose();
            //设置压缩质量     
            System.Drawing.Imaging.EncoderParameters encoderParams = new System.Drawing.Imaging.EncoderParameters();
            long[] quality = new long[1];
            quality[0] = 100;
            System.Drawing.Imaging.EncoderParameter encoderParam = new System.Drawing.Imaging.EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality);
            encoderParams.Param[0] = encoderParam;
            sourImage.Dispose();
            return destBitmap;
        }
        catch {
            return bitmap;
        }
    }

    # endregion

    # region 从Url获取图片并返回Bitmap
    /// <summary>
    /// 获取图片
    /// </summary>
    /// <param name="Url">图片地址</param>
    public static Bitmap GetPicture(string Url) {
        Url = Uri.EscapeUriString(Url);
        WebRequest webreq = WebRequest.Create(Url);
        WebResponse webres = webreq.GetResponse();
        using (Stream stream = webres.GetResponseStream()) {
            return (Bitmap)System.Drawing.Image.FromStream(stream);
        }

    }
    #endregion
    public bool HasChinese(string str) {
        return System.Text.RegularExpressions.Regex.IsMatch(str, @"[\u4e00-\u9fa5]");
    }
}