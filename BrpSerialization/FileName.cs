using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BrpSerialization
{
    // using System.Xml.Serialization;
    // XmlSerializer serializer = new XmlSerializer(typeof(ProcessPartsInvoice));
    // using (StringReader reader = new StringReader(xml))
    // {
    //    var test = (ProcessPartsInvoice)serializer.Deserialize(reader);
    // }

    [XmlRoot(ElementName = "Sender")]
    public class Sender
    {

        [XmlElement(ElementName = "ReferenceID")]
        public string ReferenceID { get; set; }

        [XmlElement(ElementName = "AuthorizationID")]
        public string AuthorizationID { get; set; }

        [XmlElement(ElementName = "CreatorNameCode")]
        public string CreatorNameCode { get; set; }

        [XmlElement(ElementName = "SenderNameCode")]
        public int SenderNameCode { get; set; }

        [XmlElement(ElementName = "DealerNumberID")]
        public int DealerNumberID { get; set; }

        [XmlElement(ElementName = "SystemVersion")]
        public int SystemVersion { get; set; }

        [XmlElement(ElementName = "ServiceID")]
        public string ServiceID { get; set; }
    }

    [XmlRoot(ElementName = "Destination")]
    public class Destination
    {

        [XmlElement(ElementName = "DestinationNameCode")]
        public string DestinationNameCode { get; set; }
    }

    [XmlRoot(ElementName = "ApplicationArea")]
    public class ApplicationArea
    {

        [XmlElement(ElementName = "Sender")]
        public Sender Sender { get; set; }

        [XmlElement(ElementName = "CreationDateTime")]
        public DateTime CreationDateTime { get; set; }

        [XmlElement(ElementName = "BODID")]
        public string BODID { get; set; }

        [XmlElement(ElementName = "Destination")]
        public Destination Destination { get; set; }
    }

    [XmlRoot(ElementName = "DocumentIdentification")]
    public class DocumentIdentification
    {

        [XmlElement(ElementName = "DocumentID")]
        public string DocumentID { get; set; }

        [XmlElement(ElementName = "AgencyRoleCode")]
        public string AgencyRoleCode { get; set; }
    }

    [XmlRoot(ElementName = "DocumentIdentificationGroup")]
    public class DocumentIdentificationGroup
    {

        [XmlElement(ElementName = "DocumentIdentification")]
        public DocumentIdentification DocumentIdentification { get; set; }
    }

    [XmlRoot(ElementName = "SubtotalBeforeDiscountsAmount")]
    public class SubtotalBeforeDiscountsAmount
    {

        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }

        [XmlText]
        public int Text { get; set; }
    }

    [XmlRoot(ElementName = "TotalDiscountAmount")]
    public class TotalDiscountAmount
    {

        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }

        [XmlText]
        public int Text { get; set; }
    }

    [XmlRoot(ElementName = "SubtotalIncludingDiscount")]
    public class SubtotalIncludingDiscount
    {

        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }

        [XmlText]
        public int Text { get; set; }
    }

    [XmlRoot(ElementName = "DeliveryChargeAmount")]
    public class DeliveryChargeAmount
    {

        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }

        [XmlText]
        public int Text { get; set; }
    }

    [XmlRoot(ElementName = "HandlingRestockChargeAmount")]
    public class HandlingRestockChargeAmount
    {

        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }

        [XmlText]
        public int Text { get; set; }
    }

    [XmlRoot(ElementName = "ServiceFreightChargeAmount")]
    public class ServiceFreightChargeAmount
    {

        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }

        [XmlText]
        public int Text { get; set; }
    }

    [XmlRoot(ElementName = "Charges")]
    public class Charges
    {

        [XmlElement(ElementName = "DeliveryChargeAmount")]
        public DeliveryChargeAmount DeliveryChargeAmount { get; set; }

        [XmlElement(ElementName = "HandlingRestockChargeAmount")]
        public HandlingRestockChargeAmount HandlingRestockChargeAmount { get; set; }

        [XmlElement(ElementName = "ServiceFreightChargeAmount")]
        public ServiceFreightChargeAmount ServiceFreightChargeAmount { get; set; }
    }

    [XmlRoot(ElementName = "TaxAmount")]
    public class TaxAmount
    {

        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }

        [XmlText]
        public double Text { get; set; }
    }

    [XmlRoot(ElementName = "TotalTaxableAmount")]
    public class TotalTaxableAmount
    {

        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }

        [XmlText]
        public int Text { get; set; }
    }

    [XmlRoot(ElementName = "Tax")]
    public class Tax
    {

        [XmlElement(ElementName = "TaxTypeCode")]
        public string TaxTypeCode { get; set; }

        [XmlElement(ElementName = "TaxAmount")]
        public TaxAmount TaxAmount { get; set; }

        [XmlElement(ElementName = "TaxRatePercent")]
        public double TaxRatePercent { get; set; }

        [XmlElement(ElementName = "TotalTaxableAmount")]
        public TotalTaxableAmount TotalTaxableAmount { get; set; }
    }

    [XmlRoot(ElementName = "TotalAmount")]
    public class TotalAmount
    {

        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }

        [XmlText]
        public double Text { get; set; }
    }

    [XmlRoot(ElementName = "TelephoneCommunication")]
    public class TelephoneCommunication
    {

        [XmlElement(ElementName = "ChannelCode")]
        public string ChannelCode { get; set; }

        [XmlElement(ElementName = "LocalNumber")]
        public double LocalNumber { get; set; }

        [XmlElement(ElementName = "AreaNumberCode")]
        public int AreaNumberCode { get; set; }
    }

    [XmlRoot(ElementName = "FaxCommunication")]
    public class FaxCommunication
    {

        [XmlElement(ElementName = "ChannelCode")]
        public string ChannelCode { get; set; }

        [XmlElement(ElementName = "LocalNumber")]
        public double LocalNumber { get; set; }

        [XmlElement(ElementName = "AreaNumberCode")]
        public int AreaNumberCode { get; set; }
    }

    [XmlRoot(ElementName = "URICommunication")]
    public class URICommunication
    {

        [XmlElement(ElementName = "URIID")]
        public string URIID { get; set; }

        [XmlElement(ElementName = "ChannelCode")]
        public string ChannelCode { get; set; }
    }

    [XmlRoot(ElementName = "SpecifiedPerson")]
    public class SpecifiedPerson
    {

        [XmlElement(ElementName = "GivenName")]
        public string GivenName { get; set; }

        [XmlElement(ElementName = "MiddleName")]
        public string MiddleName { get; set; }

        [XmlElement(ElementName = "FamilyName")]
        public string FamilyName { get; set; }

        [XmlElement(ElementName = "TelephoneCommunication")]
        public TelephoneCommunication TelephoneCommunication { get; set; }

        [XmlElement(ElementName = "FaxCommunication")]
        public FaxCommunication FaxCommunication { get; set; }

        [XmlElement(ElementName = "URICommunication")]
        public URICommunication URICommunication { get; set; }

        [XmlElement(ElementName = "ID")]
        public double ID { get; set; }
    }

    [XmlRoot(ElementName = "PostalAddress")]
    public class PostalAddress
    {

        [XmlElement(ElementName = "LineOne")]
        public string LineOne { get; set; }

        [XmlElement(ElementName = "LineTwo")]
        public string LineTwo { get; set; }

        [XmlElement(ElementName = "CityName")]
        public string CityName { get; set; }

        [XmlElement(ElementName = "CountryID")]
        public string CountryID { get; set; }

        [XmlElement(ElementName = "Postcode")]
        public int Postcode { get; set; }

        [XmlElement(ElementName = "StateOrProvinceCountrySub-DivisionID")]
        public string StateOrProvinceCountrySubDivisionID { get; set; }
    }

    [XmlRoot(ElementName = "PrimaryContact")]
    public class PrimaryContact
    {

        [XmlElement(ElementName = "TypeCode")]
        public string TypeCode { get; set; }

        [XmlElement(ElementName = "SpecifiedPerson")]
        public SpecifiedPerson SpecifiedPerson { get; set; }

        [XmlElement(ElementName = "PostalAddress")]
        public PostalAddress PostalAddress { get; set; }
    }

    [XmlRoot(ElementName = "SpecifiedOrganization")]
    public class SpecifiedOrganization
    {

        [XmlElement(ElementName = "CompanyName")]
        public string CompanyName { get; set; }

        [XmlElement(ElementName = "PrimaryContact")]
        public PrimaryContact PrimaryContact { get; set; }
    }

    [XmlRoot(ElementName = "SoldToParty")]
    public class SoldToParty
    {

        [XmlElement(ElementName = "SpecifiedOrganization")]
        public SpecifiedOrganization SpecifiedOrganization { get; set; }
    }

    [XmlRoot(ElementName = "SoldByParty")]
    public class SoldByParty
    {

        [XmlElement(ElementName = "SpecifiedPerson")]
        public SpecifiedPerson SpecifiedPerson { get; set; }
    }

    [XmlRoot(ElementName = "PartsInvoiceHeader")]
    public class PartsInvoiceHeader
    {

        [XmlElement(ElementName = "DocumentIdentificationGroup")]
        public DocumentIdentificationGroup DocumentIdentificationGroup { get; set; }

        [XmlElement(ElementName = "TransactionTypeCode")]
        public string TransactionTypeCode { get; set; }

        [XmlElement(ElementName = "ReferenceNumberString")]
        public int ReferenceNumberString { get; set; }

        [XmlElement(ElementName = "TotalPartPiecesNumeric")]
        public int TotalPartPiecesNumeric { get; set; }

        [XmlElement(ElementName = "SubtotalBeforeDiscountsAmount")]
        public SubtotalBeforeDiscountsAmount SubtotalBeforeDiscountsAmount { get; set; }

        [XmlElement(ElementName = "TotalDiscountAmount")]
        public TotalDiscountAmount TotalDiscountAmount { get; set; }

        [XmlElement(ElementName = "SubtotalIncludingDiscount")]
        public SubtotalIncludingDiscount SubtotalIncludingDiscount { get; set; }

        [XmlElement(ElementName = "Charges")]
        public Charges Charges { get; set; }

        [XmlElement(ElementName = "Tax")]
        public Tax Tax { get; set; }

        [XmlElement(ElementName = "TotalAmount")]
        public TotalAmount TotalAmount { get; set; }

        [XmlElement(ElementName = "ProcessCode")]
        public string ProcessCode { get; set; }

        [XmlElement(ElementName = "SoldToParty")]
        public SoldToParty SoldToParty { get; set; }

        [XmlElement(ElementName = "DealerOrderNumberString")]
        public int DealerOrderNumberString { get; set; }

        [XmlElement(ElementName = "PartsOrderReceivedDateTime")]
        public DateTime PartsOrderReceivedDateTime { get; set; }

        [XmlElement(ElementName = "SoldByParty")]
        public SoldByParty SoldByParty { get; set; }
    }

    [XmlRoot(ElementName = "ItemIdentification")]
    public class ItemIdentification
    {

        [XmlElement(ElementName = "ItemID")]
        public int ItemID { get; set; }
    }

    [XmlRoot(ElementName = "ItemIdentificationGroup")]
    public class ItemIdentificationGroup
    {

        [XmlElement(ElementName = "ItemIdentification")]
        public ItemIdentification ItemIdentification { get; set; }
    }

    [XmlRoot(ElementName = "PartsProductItem")]
    public class PartsProductItem
    {

        [XmlElement(ElementName = "PartItemDescription")]
        public string PartItemDescription { get; set; }

        [XmlElement(ElementName = "ItemIdentificationGroup")]
        public ItemIdentificationGroup ItemIdentificationGroup { get; set; }
    }

    [XmlRoot(ElementName = "OrderQuantity")]
    public class OrderQuantity
    {

        [XmlAttribute(AttributeName = "unitCode")]
        public string UnitCode { get; set; }

        [XmlText]
        public int Text { get; set; }
    }

    [XmlRoot(ElementName = "ChargeAmount")]
    public class ChargeAmount
    {

        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }

        [XmlText]
        public int Text { get; set; }
    }

    [XmlRoot(ElementName = "Price")]
    public class Price
    {

        [XmlElement(ElementName = "PriceCode")]
        public string PriceCode { get; set; }

        [XmlElement(ElementName = "ChargeAmount")]
        public ChargeAmount ChargeAmount { get; set; }

        [XmlElement(ElementName = "PriceDescription")]
        public string PriceDescription { get; set; }
    }

    [XmlRoot(ElementName = "PartsInvoiceLine")]
    public class PartsInvoiceLine
    {

        [XmlElement(ElementName = "LineNumberString")]
        public int LineNumberString { get; set; }

        [XmlElement(ElementName = "PartsProductItem")]
        public PartsProductItem PartsProductItem { get; set; }

        [XmlElement(ElementName = "OrderQuantity")]
        public OrderQuantity OrderQuantity { get; set; }

        [XmlElement(ElementName = "Price")]
        public List<Price> Price { get; set; }

        [XmlElement(ElementName = "Charges")]
        public Charges Charges { get; set; }

        [XmlElement(ElementName = "Tax")]
        public Tax Tax { get; set; }
    }

    [XmlRoot(ElementName = "PartsInvoice")]
    public class PartsInvoice
    {

        [XmlElement(ElementName = "PartsInvoiceHeader")]
        public PartsInvoiceHeader PartsInvoiceHeader { get; set; }

        [XmlElement(ElementName = "PartsInvoiceLine")]
        public List<PartsInvoiceLine> PartsInvoiceLine { get; set; }
    }

    [XmlRoot(ElementName = "ProcessPartsInvoiceDataArea")]
    public class ProcessPartsInvoiceDataArea
    {

        [XmlElement(ElementName = "Process")]
        public object Process { get; set; }

        [XmlElement(ElementName = "PartsInvoice")]
        public List<PartsInvoice> PartsInvoice { get; set; }
    }

    [XmlRoot(ElementName = "ProcessPartsInvoice", Namespace = "http://www.starstandard.org/STAR/5")]
    public class ProcessPartsInvoice
    {

        [XmlElement("ApplicationArea", Namespace = "http://www.starstandard.org/STAR/5")]
        public ApplicationArea ApplicationArea { get; set; }

        [XmlElement("ProcessPartsInvoiceDataArea", Namespace = "http://www.starstandard.org/STAR/5")]
        public ProcessPartsInvoiceDataArea ProcessPartsInvoiceDataArea { get; set; }

      
    }


}
