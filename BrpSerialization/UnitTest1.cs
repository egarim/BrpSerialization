using NUnit.Framework;
using System.IO;
using System.Xml.Serialization;

namespace BrpSerialization
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {

            XmlSerializer serializer = new XmlSerializer(typeof(ProcessPartsInvoice));
            ProcessPartsInvoice processPartsInvoice = (ProcessPartsInvoice)serializer.Deserialize(new FileStream("data.xml", FileMode.Open));
            //ProcessPartsInvoice processPartsInvoice = new ProcessPartsInvoice();

            //processPartsInvoice.Star = "star";
            //processPartsInvoice.ProcessPartsInvoiceDataArea = new ProcessPartsInvoiceDataArea();
            //processPartsInvoice.ProcessPartsInvoiceDataArea.PartsInvoice = new System.Collections.Generic.List<PartsInvoice>();
            //processPartsInvoice.ProcessPartsInvoiceDataArea.PartsInvoice.Add(
            //    new PartsInvoice() 
            //    { 
            //        PartsInvoiceHeader=new PartsInvoiceHeader() {  ReferenceNumberString=1 }
            //    }
            //    );
           StringWriter textWriter = new StringWriter();
            serializer.Serialize(textWriter, processPartsInvoice);

            string xml = textWriter.ToString();
        
            using (StringReader reader = new StringReader(xml))
            {
                var test = (ProcessPartsInvoice)serializer.Deserialize(reader);
            }
            Assert.Pass();
        }
    }
}