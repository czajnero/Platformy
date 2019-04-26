using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTTT
{
    [Serializable]
    class ShowResult : JTTTAction
    {
        public string Subject
        {
            get
            {
                try
                {
                    return (string)InputParameters[0];
                }
                catch (Exception e)
                {

                }
                return null;
            }

        }

        public string Body
        {
            get
            {
                try
                {
                    return (string)InputParameters[1];
                }
                catch (Exception e)
                {

                }
                return null;
            }
        }

        public MemoryStream Image
        {
            get
            {
                try
                {
                    return (MemoryStream)InputParameters[2];
                }
                catch (Exception e)
                {

                }
                return null;
            }
        }
        public ShowResult() { }

        public override void Action()
        {
            try
            {
                ResultForm resultForm = new ResultForm();
                resultForm.Subject = Subject;
                resultForm.Body = Body;
                resultForm.Imagestream = Image;
                resultForm.Show();

            }
            catch (Exception e)
            {

            }
        }

        public override string ToString()
        {
            return "";
        }
    }
}
