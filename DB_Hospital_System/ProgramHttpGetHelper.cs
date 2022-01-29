using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace HospitalManagementSystem {
    class ProgramHttpGetHelper {
        //申请Web服务API类型Key
        //key=d8440a22fb3fc04b72a61aa6b51902a2

        /// <summary>
        /// 高德地图解析函数
        /// </summary>
        /// <param name="strResult">返回结果</param>
        public static string GaoDeAnalysis(string parameters) {       
        //parameter为key+经度+纬度，返回表示位置信息的字符串
            string strResult = "";
            string url = string.Format(
                "http://restapi.amap.com/v3/geocode/regeo?{0}", parameters);
            //向网页发出请求，申请的key和经度、纬度也要一同发送
            try {
                HttpWebRequest req = WebRequest.Create(url) as HttpWebRequest;
                req.ContentType = "multipart/form-data";
                req.Accept = "*/*";
                req.UserAgent = "";
                req.Timeout = 30000;//30秒连接不成功就中断 
                req.Method = "GET";
                req.KeepAlive = true;
                //网页会返回数据，数据类型为JSON，数据编码为UTF-8编码格式
                HttpWebResponse response = req.GetResponse() as HttpWebResponse;
                using (StreamReader sr = new StreamReader(
                    response.GetResponseStream(), Encoding.UTF8)) {
                    strResult = sr.ReadToEnd();
                }
            }
            catch (Exception ex) {
                throw new Exception(string.Format("连接失败，原因：{0}", ex.Message));
            }
            return strResult;
        }
    }
}