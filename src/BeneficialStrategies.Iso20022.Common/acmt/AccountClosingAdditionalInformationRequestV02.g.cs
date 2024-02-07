﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AccountClosingAdditionalInformationRequestV02.  ISO2002 ID# _QvJSwQ1TEeKGXqvMN6jpiw.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.acmt.AccountClosingAdditionalInformationRequestV02>;

namespace BeneficialStrategies.Iso20022.acmt;


/// <summary>
/// This record is an implementation of the acmt.021.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AccountClosingAdditionalInformationRequest message is sent from a financial institution to an organisation as part of the account closing process. This message is sent in response to a closing request message from the organisation, if the business content is valid, but additional information is required.
/// </summary>
[Serializable]
[Description(@"The AccountClosingAdditionalInformationRequest message is sent from a financial institution to an organisation as part of the account closing process. This message is sent in response to a closing request message from the organisation, if the business content is valid, but additional information is required.")]
public partial record AccountClosingAdditionalInformationRequestV02 : IOuterRecord<AccountClosingAdditionalInformationRequestV02,AccountClosingAdditionalInformationRequestV02Document>
    ,IIsoXmlSerilizable<AccountClosingAdditionalInformationRequestV02>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "acmt.021.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctClsgAddtlInfReq";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => AccountClosingAdditionalInformationRequestV02Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Set of elements for the identification of the message and related references.
    /// </summary>
    [IsoId("_QvJSww1TEeKGXqvMN6jpiw")]
    [Description(@"Set of elements for the identification of the message and related references.")]
    [DataMember(Name="Refs")]
    [XmlElement(ElementName="Refs")]
    [Required]
    public required References3 References { get; init; }
    
    /// <summary>
    /// Identifies the business sender of the message, if it is not the account owner or account servicing financial institution.
    /// </summary>
    [IsoId("_g4JZ0A1XEeKGXqvMN6jpiw")]
    [Description(@"Identifies the business sender of the message, if it is not the account owner or account servicing financial institution.")]
    [DataMember(Name="Fr")]
    [XmlElement(ElementName="Fr")]
    public OrganisationIdentification8? From { get; init; }
    
    /// <summary>
    /// Identifier for an organisation.
    /// </summary>
    [IsoId("_QvJSxw1TEeKGXqvMN6jpiw")]
    [Description(@"Identifier for an organisation.")]
    [DataMember(Name="OrgId")]
    [XmlElement(ElementName="OrgId")]
    [Required]
    public required OrganisationIdentification8 OrganisationIdentification { get; init; }
    
    /// <summary>
    /// Unique and unambiguous identification of the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_QvJSyw1TEeKGXqvMN6jpiw")]
    [Description(@"Unique and unambiguous identification of the account between the account owner and the account servicer.")]
    [DataMember(Name="AcctId")]
    [XmlElement(ElementName="AcctId")]
    [Required]
    public required AccountForAction1 AccountIdentification { get; init; }
    
    /// <summary>
    /// Unique and unambiguous identifier of a financial institution, as assigned under an internationally recognised or proprietary identification scheme. |.
    /// </summary>
    [IsoId("_QvJSzw1TEeKGXqvMN6jpiw")]
    [Description(@"Unique and unambiguous identifier of a financial institution, as assigned under an internationally recognised or proprietary identification scheme. |.")]
    [DataMember(Name="AcctSvcrId")]
    [XmlElement(ElementName="AcctSvcrId")]
    [Required]
    public required BranchAndFinancialInstitutionIdentification5 AccountServicerIdentification { get; init; }
    
    /// <summary>
    /// Identification of the account to which the remaining positive balance of the account to be closed must be transferred or account from which funds can be moved to the account to be closed and which balance is negative. This account must be held in the same financial institution as the account to be closed if the transfer account is used to compensate a negative balance. For a positive balance to be transferred, an account in another financial institution might be used. In that case the account servicer is mandatory.
    /// </summary>
    [IsoId("_QvJS0w1TEeKGXqvMN6jpiw")]
    [Description(@"Identification of the account to which the remaining positive balance of the account to be closed must be transferred or account from which funds can be moved to the account to be closed and which balance is negative. This account must be held in the same financial institution as the account to be closed if the transfer account is used to compensate a negative balance. For a positive balance to be transferred, an account in another financial institution might be used. In that case the account servicer is mandatory.")]
    [DataMember(Name="BalTrfAcct")]
    [XmlElement(ElementName="BalTrfAcct")]
    public AccountForAction1? BalanceTransferAccount { get; init; }
    
    /// <summary>
    /// Unique and unambiguous identifier of a financial institution, as assigned under an internationally recognised or proprietary identification scheme, that is the servicer of the transfer account.
    /// </summary>
    [IsoId("_QvJS1w1TEeKGXqvMN6jpiw")]
    [Description(@"Unique and unambiguous identifier of a financial institution, as assigned under an internationally recognised or proprietary identification scheme, that is the servicer of the transfer account.")]
    [DataMember(Name="TrfAcctSvcrId")]
    [XmlElement(ElementName="TrfAcctSvcrId")]
    public BranchAndFinancialInstitutionIdentification5? TransferAccountServicerIdentification { get; init; }
    
    /// <summary>
    /// Contains the signature with its components, namely signed info, signature value, key info and the object.
    /// </summary>
    [IsoId("_QvJS2w1TEeKGXqvMN6jpiw")]
    [Description(@"Contains the signature with its components, namely signed info, signature value, key info and the object.")]
    [DataMember(Name="DgtlSgntr")]
    [XmlElement(ElementName="DgtlSgntr")]
    public PartyAndSignature2? DigitalSignature { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_6aME4A4AEeKGXqvMN6jpiw")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AccountClosingAdditionalInformationRequestV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AccountClosingAdditionalInformationRequestV02Document ToDocument()
    {
        return new AccountClosingAdditionalInformationRequestV02Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("AcctClsgAddtlInfReq");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "Refs", xmlNamespace );
        References.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (From is OrganisationIdentification8 FromValue)
        {
            writer.WriteStartElement(null, "Fr", xmlNamespace );
            FromValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "OrgId", xmlNamespace );
        OrganisationIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "AcctId", xmlNamespace );
        AccountIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "AcctSvcrId", xmlNamespace );
        AccountServicerIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (BalanceTransferAccount is AccountForAction1 BalanceTransferAccountValue)
        {
            writer.WriteStartElement(null, "BalTrfAcct", xmlNamespace );
            BalanceTransferAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TransferAccountServicerIdentification is BranchAndFinancialInstitutionIdentification5 TransferAccountServicerIdentificationValue)
        {
            writer.WriteStartElement(null, "TrfAcctSvcrId", xmlNamespace );
            TransferAccountServicerIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DigitalSignature is PartyAndSignature2 DigitalSignatureValue)
        {
            writer.WriteStartElement(null, "DgtlSgntr", xmlNamespace );
            DigitalSignatureValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static AccountClosingAdditionalInformationRequestV02 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AccountClosingAdditionalInformationRequestV02"/>.
/// </summary>
[Serializable]
public partial record AccountClosingAdditionalInformationRequestV02Document : IOuterDocument<AccountClosingAdditionalInformationRequestV02>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.021.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AccountClosingAdditionalInformationRequestV02"/> is required.
    /// </summary>
    [DataMember(Name=AccountClosingAdditionalInformationRequestV02.XmlTag)]
    public required AccountClosingAdditionalInformationRequestV02 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(AccountClosingAdditionalInformationRequestV02.XmlTag);
        Message.Serialize(writer, DocumentNamespace);
        writer.WriteEndElement();
        writer.WriteEndElement();
        writer.WriteEndDocument();
    }
    
    public void ReadXml(XmlReader reader)
    {
        throw new NotImplementedException();
    }
    
    public System.Xml.Schema.XmlSchema GetSchema() => null;
}
