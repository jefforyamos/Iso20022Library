﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CommonData5.  ISO2002 ID# _REJZUY3JEeWjkqXgn_0Imw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data common to all transactions of a data set.
/// </summary>
public partial record CommonData5
     : IIsoXmlSerilizable<CommonData5>
{
    #nullable enable
    
    /// <summary>
    /// Data related to the environment of the transaction, common to a set of transaction.
    /// </summary>
    public CardPaymentEnvironment51? Environment { get; init; } 
    /// <summary>
    /// Data related to the context of the transaction, common to a set of transaction.
    /// </summary>
    public CardPaymentContext18? Context { get; init; } 
    /// <summary>
    /// Type of transaction being undertaken for the main service, common to a set of transaction.
    /// </summary>
    public CardPaymentServiceType5Code? TransactionType { get; init; } 
    /// <summary>
    /// Service in addition to the main service.
    /// </summary>
    public CardPaymentServiceType9Code? AdditionalService { get; init; } 
    /// <summary>
    /// Additional attribute of the service type.
    /// </summary>
    public CardPaymentServiceType3Code? ServiceAttribute { get; init; } 
    /// <summary>
    /// Category code conform to ISO 18245, related to the type of services or goods the merchant provides for the transaction.
    /// </summary>
    public IsoMin3Max4Text? MerchantCategoryCode { get; init; } 
    /// <summary>
    /// Unique identification of the reconciliation period between the acceptor and the acquirer. This identification might be linked to the identification of the settlement for further verification by the merchant.
    /// </summary>
    public IsoMax35Text? ReconciliationIdentification { get; init; } 
    /// <summary>
    /// Currency associated with the set of transaction.
    /// </summary>
    public CurrencyCode? Currency { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        if (Environment is CardPaymentEnvironment51 EnvironmentValue)
        {
            writer.WriteStartElement(null, "Envt", xmlNamespace );
            EnvironmentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Context is CardPaymentContext18 ContextValue)
        {
            writer.WriteStartElement(null, "Cntxt", xmlNamespace );
            ContextValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TransactionType is CardPaymentServiceType5Code TransactionTypeValue)
        {
            writer.WriteStartElement(null, "TxTp", xmlNamespace );
            writer.WriteValue(TransactionTypeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (AdditionalService is CardPaymentServiceType9Code AdditionalServiceValue)
        {
            writer.WriteStartElement(null, "AddtlSvc", xmlNamespace );
            writer.WriteValue(AdditionalServiceValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (ServiceAttribute is CardPaymentServiceType3Code ServiceAttributeValue)
        {
            writer.WriteStartElement(null, "SvcAttr", xmlNamespace );
            writer.WriteValue(ServiceAttributeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (MerchantCategoryCode is IsoMin3Max4Text MerchantCategoryCodeValue)
        {
            writer.WriteStartElement(null, "MrchntCtgyCd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMin3Max4Text(MerchantCategoryCodeValue)); // data type Min3Max4Text System.String
            writer.WriteEndElement();
        }
        if (ReconciliationIdentification is IsoMax35Text ReconciliationIdentificationValue)
        {
            writer.WriteStartElement(null, "RcncltnId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ReconciliationIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (Currency is CurrencyCode CurrencyValue)
        {
            writer.WriteStartElement(null, "Ccy", xmlNamespace );
            writer.WriteValue(CurrencyValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
    }
    public static CommonData5 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
