﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ReturnCurrencyExchangeRateV04.  ISO2002 ID# _jwlcCRbvEeiyVv5j1vf1VQ.
//
namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// Scope
/// The ReturnCurrencyExchangeRate message is sent by the transaction administrator to a member of the system.
/// It is used to provide information on static data and related to currency exchange details as maintained for system operations by the transaction administrator.
/// The ReturnCurrencyExchangeRate message can be sent as a response to a related GetCurrencyExchangeRate message (pull mode) or initiated by the account servicer (push mode). The push of information can take place either at prearranged times or as a warning or alarm when a problem has occurred.
/// Usage
/// The transaction administrator is in charge of providing the members with business information. The term business information covers all information related to the management of the system, that is, not related to the transactions or requests created in the system. The type of business information available can vary depending on the system.
/// When a system manages a pool of accounts in various currencies for a member, it needs to maintain currency exchange details between the various currencies and the reporting on base currency. The reporting on base currency is used to calculate the actual position of the members in terms of aggregate limits and balances. It also allows the system to contain risk within defined and agreed boundaries.
/// The currency exchange details can be fixed for the entire operational day or regularly updated according to near real-time market feeds.
/// The member can request information about a currency exchange operation through a series of criteria, corresponding to the known information stored within the transaction administrator. Based on the criteria received within the request, the transaction administrator will select items that will match with the request and report them to the requestor.
/// The transaction administrator may also send a Return Currency Exchange Rate message with pre-defined information at times previously agreed with the member or to warn the member about a particular problem that may have arisen and which needs the member(s) attention.
/// The message from the transaction administrator will contain information based on the following elements:
/// - the currency to be converted (source currency)
/// - the currency into which the amount is converted (target currency)
/// - the exchange rate
/// - the quotation date and currency
/// Additional information on the generic design of the Get/Return messages can be found in the MDR Part 1 section How to Use the Cash Management Messages.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The ReturnCurrencyExchangeRate message is sent by the transaction administrator to a member of the system.|It is used to provide information on static data and related to currency exchange details as maintained for system operations by the transaction administrator.|The ReturnCurrencyExchangeRate message can be sent as a response to a related GetCurrencyExchangeRate message (pull mode) or initiated by the account servicer (push mode). The push of information can take place either at prearranged times or as a warning or alarm when a problem has occurred.|Usage|The transaction administrator is in charge of providing the members with business information. The term business information covers all information related to the management of the system, that is, not related to the transactions or requests created in the system. The type of business information available can vary depending on the system.|When a system manages a pool of accounts in various currencies for a member, it needs to maintain currency exchange details between the various currencies and the reporting on base currency. The reporting on base currency is used to calculate the actual position of the members in terms of aggregate limits and balances. It also allows the system to contain risk within defined and agreed boundaries.|The currency exchange details can be fixed for the entire operational day or regularly updated according to near real-time market feeds.|The member can request information about a currency exchange operation through a series of criteria, corresponding to the known information stored within the transaction administrator. Based on the criteria received within the request, the transaction administrator will select items that will match with the request and report them to the requestor.|The transaction administrator may also send a Return Currency Exchange Rate message with pre-defined information at times previously agreed with the member or to warn the member about a particular problem that may have arisen and which needs the member(s) attention.|The message from the transaction administrator will contain information based on the following elements:|- the currency to be converted (source currency)|- the currency into which the amount is converted (target currency)|- the exchange rate|- the quotation date and currency|Additional information on the generic design of the Get/Return messages can be found in the MDR Part 1 section How to Use the Cash Management Messages.")]
public partial record ReturnCurrencyExchangeRateV04 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RtrCcyXchgRate";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_jwlcCxbvEeiyVv5j1vf1VQ")]
    [Description(@"Common business identification for the message.")]
    [DataMember(Name="MsgHdr")]
    [XmlElement(ElementName="MsgHdr")]
    [Required]
    public required SomeMessageHeaderRecord MessageHeader { get; init; }
    
    /// <summary>
    /// Reports on currency exchange information.
    /// </summary>
    [IsoId("_jwlcDRbvEeiyVv5j1vf1VQ")]
    [Description(@"Reports on currency exchange information.")]
    [DataMember(Name="RptOrErr")]
    [XmlElement(ElementName="RptOrErr")]
    [Required]
    public required SomeReportOrErrorRecord ReportOrError { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_jwlcDxbvEeiyVv5j1vf1VQ")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ReturnCurrencyExchangeRateV04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ReturnCurrencyExchangeRateV04Document ToDocument()
    {
        return new ReturnCurrencyExchangeRateV04Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ReturnCurrencyExchangeRateV04"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ReturnCurrencyExchangeRateV04Document : IOuterDocument<ReturnCurrencyExchangeRateV04>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.017.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ReturnCurrencyExchangeRateV04"/> is required.
    /// </summary>
    public required ReturnCurrencyExchangeRateV04 Message { get; init; }
}
