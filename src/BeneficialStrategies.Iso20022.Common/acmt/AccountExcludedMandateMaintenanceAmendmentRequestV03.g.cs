﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AccountExcludedMandateMaintenanceAmendmentRequestV03.  ISO2002 ID# _bfzgrW2PEei3KuUgpx7Xcw.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.acmt.AccountExcludedMandateMaintenanceAmendmentRequestV03>;

namespace BeneficialStrategies.Iso20022.acmt;


/// <summary>
/// This record is an implementation of the acmt.016.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AccountExcludedMandateMaintenanceAmendmentRequest message is sent from an organisation to a financial institution as part of the account maintenance process. It is sent in response to a request from the financial institution to send additional information. Usage: this update is about account details excluding any mandate information. 
/// If modification codes are not used: the organisation will specify under the “Account” and “Organisation” tags the complete information as it should be in the financial institution’s records after processing the update request. 
/// If modification codes are used (in that case, they must be used everywhere): the organisation will specify under the “Account” and “Organisation” tags which elements must be added, deleted, modified, or if they are unchanged.
/// </summary>
[Serializable]
[Description(@"The AccountExcludedMandateMaintenanceAmendmentRequest message is sent from an organisation to a financial institution as part of the account maintenance process. It is sent in response to a request from the financial institution to send additional information. Usage: this update is about account details excluding any mandate information. |If modification codes are not used: the organisation will specify under the “Account” and “Organisation” tags the complete information as it should be in the financial institution’s records after processing the update request. |If modification codes are used (in that case, they must be used everywhere): the organisation will specify under the “Account” and “Organisation” tags which elements must be added, deleted, modified, or if they are unchanged.")]
public partial record AccountExcludedMandateMaintenanceAmendmentRequestV03 : IOuterRecord<AccountExcludedMandateMaintenanceAmendmentRequestV03,AccountExcludedMandateMaintenanceAmendmentRequestV03Document>
    ,IIsoXmlSerilizable<AccountExcludedMandateMaintenanceAmendmentRequestV03>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "acmt.016.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctExcldMndtMntncAmdmntReq";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => AccountExcludedMandateMaintenanceAmendmentRequestV03Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Set of elements for the identification of the message and related references.
    /// </summary>
    [IsoId("_bfzgr22PEei3KuUgpx7Xcw")]
    [Description(@"Set of elements for the identification of the message and related references.")]
    [DataMember(Name="Refs")]
    [XmlElement(ElementName="Refs")]
    [Required]
    public required References4 References { get; init; }
    
    /// <summary>
    /// Identifies the business sender of the message, if it is not the account owner or account servicing financial institution.
    /// </summary>
    [IsoId("_bfzgsW2PEei3KuUgpx7Xcw")]
    [Description(@"Identifies the business sender of the message, if it is not the account owner or account servicing financial institution.")]
    [DataMember(Name="Fr")]
    [XmlElement(ElementName="Fr")]
    public OrganisationIdentification29? From { get; init; }
    
    /// <summary>
    /// Specifies target dates.
    /// </summary>
    [IsoId("_bfzgs22PEei3KuUgpx7Xcw")]
    [Description(@"Specifies target dates.")]
    [DataMember(Name="CtrctDts")]
    [XmlElement(ElementName="CtrctDts")]
    public AccountContract2? ContractDates { get; init; }
    
    /// <summary>
    /// Account contract established between the organisation or the group to which the organisation belongs, and the account servicer. This contract has to be applied for the new account to be opened and maintained.
    /// </summary>
    [IsoId("_bfzgtW2PEei3KuUgpx7Xcw")]
    [Description(@"Account contract established between the organisation or the group to which the organisation belongs, and the account servicer. This contract has to be applied for the new account to be opened and maintained.")]
    [DataMember(Name="UndrlygMstrAgrmt")]
    [XmlElement(ElementName="UndrlygMstrAgrmt")]
    public ContractDocument1? UnderlyingMasterAgreement { get; init; }
    
    /// <summary>
    /// Unique and unambiguous identification of the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_bfzgt22PEei3KuUgpx7Xcw")]
    [Description(@"Unique and unambiguous identification of the account between the account owner and the account servicer.")]
    [DataMember(Name="Acct")]
    [XmlElement(ElementName="Acct")]
    [Required]
    public required CustomerAccountModification1 Account { get; init; }
    
    /// <summary>
    /// Unique and unambiguous identifier of a financial institution, as assigned under an internationally recognised or proprietary identification scheme.
    /// </summary>
    [IsoId("_bfzguW2PEei3KuUgpx7Xcw")]
    [Description(@"Unique and unambiguous identifier of a financial institution, as assigned under an internationally recognised or proprietary identification scheme.")]
    [DataMember(Name="AcctSvcrId")]
    [XmlElement(ElementName="AcctSvcrId")]
    [Required]
    public required BranchAndFinancialInstitutionIdentification6 AccountServicerIdentification { get; init; }
    
    /// <summary>
    /// Organised structure that is set up for a particular purpose, for example, a business, government body, department, charity, or financial institution.
    /// </summary>
    [IsoId("_bfzgu22PEei3KuUgpx7Xcw")]
    [Description(@"Organised structure that is set up for a particular purpose, for example, a business, government body, department, charity, or financial institution.")]
    [DataMember(Name="Org")]
    [XmlElement(ElementName="Org")]
    [Required]
    public required OrganisationModification2 Organisation { get; init; }
    
    /// <summary>
    /// Contains the signature with its components, namely signed info, signature value, key info and the object.
    /// </summary>
    [IsoId("_bfzgvW2PEei3KuUgpx7Xcw")]
    [Description(@"Contains the signature with its components, namely signed info, signature value, key info and the object.")]
    [DataMember(Name="DgtlSgntr")]
    [XmlElement(ElementName="DgtlSgntr")]
    public PartyAndSignature3? DigitalSignature { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_bfzgv22PEei3KuUgpx7Xcw")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AccountExcludedMandateMaintenanceAmendmentRequestV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AccountExcludedMandateMaintenanceAmendmentRequestV03Document ToDocument()
    {
        return new AccountExcludedMandateMaintenanceAmendmentRequestV03Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("AcctExcldMndtMntncAmdmntReq");
    
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
        if (From is OrganisationIdentification29 FromValue)
        {
            writer.WriteStartElement(null, "Fr", xmlNamespace );
            FromValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ContractDates is AccountContract2 ContractDatesValue)
        {
            writer.WriteStartElement(null, "CtrctDts", xmlNamespace );
            ContractDatesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (UnderlyingMasterAgreement is ContractDocument1 UnderlyingMasterAgreementValue)
        {
            writer.WriteStartElement(null, "UndrlygMstrAgrmt", xmlNamespace );
            UnderlyingMasterAgreementValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Acct", xmlNamespace );
        Account.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "AcctSvcrId", xmlNamespace );
        AccountServicerIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Org", xmlNamespace );
        Organisation.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (DigitalSignature is PartyAndSignature3 DigitalSignatureValue)
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
    public static AccountExcludedMandateMaintenanceAmendmentRequestV03 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AccountExcludedMandateMaintenanceAmendmentRequestV03"/>.
/// </summary>
[Serializable]
public partial record AccountExcludedMandateMaintenanceAmendmentRequestV03Document : IOuterDocument<AccountExcludedMandateMaintenanceAmendmentRequestV03>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.016.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AccountExcludedMandateMaintenanceAmendmentRequestV03"/> is required.
    /// </summary>
    [DataMember(Name=AccountExcludedMandateMaintenanceAmendmentRequestV03.XmlTag)]
    public required AccountExcludedMandateMaintenanceAmendmentRequestV03 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(AccountExcludedMandateMaintenanceAmendmentRequestV03.XmlTag);
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
