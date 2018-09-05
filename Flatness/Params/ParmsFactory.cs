using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XmlConfiguration;
using System.Xml;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace Params
{
    public class ParmsFactory
    {
        /// <summary>
        /// 反序列化XML文件，如文件不存在，则序列化对象，
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="path"></param>
        /// <param name="t"></param>
        public static void Load<T>(string path, ref T t)    
        {
            try
            {
                if (!File.Exists(path))
                {
                    if (MessageBox.Show("文件"+path+"不存在！是否新建文件？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        XmlWriterSettings xwset = new XmlWriterSettings();
                        xwset.Indent = true;    //新建的XML文件是否有缩进值，如没有则XML文件不会换行
                        using (XmlWriter writer = XmlWriter.Create(path,xwset))
                        {
                            XmlSerializer xs = new XmlSerializer(typeof(T));
                            xs.Serialize(writer, t);
                        }
                    }
                   
                }
                using (XmlReader reader = XmlReader.Create(path))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(T));
                    t = (T)xs.Deserialize(reader);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 保存params对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="path"></param>
        /// <param name="t"></param>
        public static  void SaveParams<T>(string path,T t)
        {
            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(T));
                XmlWriterSettings set = new XmlWriterSettings();
                set.Indent = true;
                using (XmlWriter writer = XmlWriter.Create(path, set))
                {
                    xs.Serialize(writer, t);
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
