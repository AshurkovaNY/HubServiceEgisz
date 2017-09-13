using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace ServiceNsi
{
    public class ServiceNsi : IServiceNsi
    {
        #region F001

        /// <summary>
        /// Метод возвращающий данные справочника F001 в формате JSON
        /// </summary>
        /// <returns></returns>
        public string Getf001()
        {
            string path = Directory.GetCurrentDirectory();
            string xmlFileName = "F001.xml";
            XDocument xDocPlan = XDocument.Load(path + @"\xml\" + xmlFileName);
            List<F001> listF001s = new List<F001>();


            foreach (XElement el in xDocPlan.Elements())
            {
                foreach (XElement TFOMS in el.Elements("TFOMS"))
                {
                    var f001 = new F001();
                    foreach (var code in TFOMS.Elements())
                    {
                        if (code.Name == "tf_code") f001.tf_code = code.Value;
                        if (code.Name == "tf_ogrn") f001.tf_ogrn = code.Value;
                        if (code.Name == "name_tfp") f001.name_tfp = code.Value;
                        if (code.Name == "name_tfp") f001.name_tfk = code.Value;
                        if (code.Name == "post_index") f001.post_index = code.Value;
                        if (code.Name == "address") f001.address = code.Value;
                        if (code.Name == "fam_dir") f001.fam_dir = code.Value;
                        if (code.Name == "im_dir") f001.im_dir = code.Value;
                        if (code.Name == "ot_dir") f001.ot_dir = code.Value;
                        if (code.Name == "phone") f001.phone = code.Value;
                        if (code.Name == "fax") f001.fax = code.Value;
                        if (code.Name == "e_mail") f001.e_mail = code.Value;
                        if (code.Name == "kf_tf")
                            f001.kf_tf = code.Value != "" ? Convert.ToDecimal(code.Value) : Decimal.One;
                        if (code.Name == "www") f001.www = code.Value;
                        if (code.Name == "d_edit") f001.d_edit = Convert.ToDateTime(code.Value);
                        if (code.Name == "d_end")
                            f001.d_end = code.Value != "" ? Convert.ToDateTime(code.Value) : (DateTime?) null;

                    }
                    listF001s.Add(f001);
                }
            }
            return JsonConvert.SerializeObject(listF001s);
        }

        #endregion

        /// <summary>
        /// Метод возвращающий данные справочника F001 в формате JSON
        /// </summary>
        /// <returns></returns>
        public string Getf002()
        {
            throw new NotImplementedException();
        }
    }
}
