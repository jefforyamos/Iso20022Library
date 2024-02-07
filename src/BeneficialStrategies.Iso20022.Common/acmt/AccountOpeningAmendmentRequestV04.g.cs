﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AccountOpeningAmendmentRequestV04.  ISO2002 ID# _1ENlr9cAEeq_l4BJLVUF2Q.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.acmt.AccountOpeningAmendmentRequestV04>;

namespace BeneficialStrategies.Iso20022.acmt;


/// <summary>
/// This record is an implementation of the acmt.008.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AccountOpeningAmendmentRequest message is sent from an organisation to a financial institution as part of the account opening process. It is sent in response to a request from the financial institution to send additional information.
/// </summary>
[Serializable]
[Description(@"The AccountOpeningAmendmentRequest message is sent from an organisation to a financial institution as part of the account opening process. It is sent in response to a request from the financial institution to send additional information.")]
public partial record AccountOpeningAmendmentRequestV04 : IOuterRecord<AccountOpeningAmendmentRequestV04,AccountOpeningAmendmentRequestV04Document>
    ,IIsoXmlSerilizable<AccountOpeningAmendmentRequestV04>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "acmt.008.001.04";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctOpngAmdmntReq";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => AccountOpeningAmendmentRequestV04Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Set of elements for the identification of the message and related references.
    /// </summary>
    [IsoId("_1ENltdcAEeq_l4BJLVUF2Q")]
    [Description(@"Set of elements for the identification of the message and related references.")]
    [DataMember(Name="Refs")]
    [XmlElement(ElementName="Refs")]
    [Required]
    public required References4 References { get; init; }
    
    /// <summary>
    /// Identifies the business sender of the message, if it is not the account owner or account servicing financial institution.
    /// </summary>
    [IsoId("_1ENlt9cAEeq_l4BJLVUF2Q")]
    [Description(@"Identifies the business sender of the message, if it is not the account owner or account servicing financial institution.")]
    [DataMember(Name="Fr")]
    [XmlElement(ElementName="Fr")]
    public OrganisationIdentification29? From { get; init; }
    
    /// <summary>
    /// Specifies target dates.
    /// </summary>
    [IsoId("_1ENludcAEeq_l4BJLVUF2Q")]
    [Description(@"Specifies target dates.")]
    [DataMember(Name="CtrctDts")]
    [XmlElement(ElementName="CtrctDts")]
    public AccountContract2? ContractDates { get; init; }
    
    /// <summary>
    /// Account contract established between the organisation or the group to which the organisation belongs, and the account servicer. This contract has to be applied for the new account to be opened and maintained.
    /// </summary>
    [IsoId("_1ENlu9cAEeq_l4BJLVUF2Q")]
    [Description(@"Account contract established between the organisation or the group to which the organisation belongs, and the account servicer. This contract has to be applied for the new account to be opened and maintained.")]
    [DataMember(Name="UndrlygMstrAgrmt")]
    [XmlElement(ElementName="UndrlygMstrAgrmt")]
    public ContractDocument1? UnderlyingMasterAgreement { get; init; }
    
    /// <summary>
    /// Unique and unambiguous identification of the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_1ENlvdcAEeq_l4BJLVUF2Q")]
    [Description(@"Unique and unambiguous identification of the account between the account owner and the account servicer.")]
    [DataMember(Name="Acct")]
    [XmlElement(ElementName="Acct")]
    [Required]
    public required CustomerAccount4 Account { get; init; }
    
    /// <summary>
    /// Unique and unambiguous identifier of a financial institution, as assigned under an internationally recognised or proprietary identification scheme.
    /// </summary>
    [IsoId("_1ENlv9cAEeq_l4BJLVUF2Q")]
    [Description(@"Unique and unambiguous identifier of a financial institution, as assigned under an internationally recognised or proprietary identification scheme.")]
    [DataMember(Name="AcctSvcrId")]
    [XmlElement(ElementName="AcctSvcrId")]
    [Required]
    public required BranchAndFinancialInstitutionIdentification6 AccountServicerIdentification { get; init; }
    
    /// <summary>
    /// Organised structure that is set up for a particular purpose, for example, a business, government body, department, charity, or financial institution.
    /// </summary>
    [IsoId("_1ENlwdcAEeq_l4BJLVUF2Q")]
    [Description(@"Organised structure that is set up for a particular purpose, for example, a business, government body, department, charity, or financial institution.")]
    [DataMember(Name="Org")]
    [XmlElement(ElementName="Org")]
    [Required]
    public required Organisation33 Organisation { get; init; }
    
    /// <summary>
    /// Information specifying the account mandate.
    /// </summary>
    [IsoId("_1ENlw9cAEeq_l4BJLVUF2Q")]
    [Description(@"Information specifying the account mandate.")]
    [DataMember(Name="Mndt")]
    [XmlElement(ElementName="Mndt")]
    public OperationMandate4? Mandate { get; init; }
    
    /// <summary>
    /// Definition of a group of parties.
    /// </summary>
    [IsoId("_1ENlxdcAEeq_l4BJLVUF2Q")]
    [Description(@"Definition of a group of parties.")]
    [DataMember(Name="Grp")]
    [XmlElement(ElementName="Grp")]
    public Group4? Group { get; init; }
    
    /// <summary>
    /// Unique and unambiguous identification of the account used as a reference for the opening of another account.
    /// </summary>
    [IsoId("_1ENlx9cAEeq_l4BJLVUF2Q")]
    [Description(@"Unique and unambiguous identification of the account used as a reference for the opening of another account.")]
    [DataMember(Name="RefAcct")]
    [XmlElement(ElementName="RefAcct")]
    public CashAccount40? ReferenceAccount { get; init; }
    
    /// <summary>
    /// Contains the signature with its components, namely signed info, signature value, key info and the object.
    /// </summary>
    [IsoId("_1ENlydcAEeq_l4BJLVUF2Q")]
    [Description(@"Contains the signature with its components, namely signed info, signature value, key info and the object.")]
    [DataMember(Name="DgtlSgntr")]
    [XmlElement(ElementName="DgtlSgntr")]
    public PartyAndSignature3? DigitalSignature { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_1ENly9cAEeq_l4BJLVUF2Q")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AccountOpeningAmendmentRequestV04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AccountOpeningAmendmentRequestV04Document ToDocument()
    {
        return new AccountOpeningAmendmentRequestV04Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("AcctOpngAmdmntReq");
    
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
        if (Mandate is OperationMandate4 MandateValue)
        {
            writer.WriteStartElement(null, "Mndt", xmlNamespace );
            MandateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Group is Group4 GroupValue)
        {
            writer.WriteStartElement(null, "Grp", xmlNamespace );
            GroupValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ReferenceAccount is CashAccount40 ReferenceAccountValue)
        {
            writer.WriteStartElement(null, "RefAcct", xmlNamespace );
            ReferenceAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
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
    public static AccountOpeningAmendmentRequestV04 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AccountOpeningAmendmentRequestV04"/>.
/// </summary>
[Serializable]
public partial record AccountOpeningAmendmentRequestV04Document : IOuterDocument<AccountOpeningAmendmentRequestV04>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.008.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AccountOpeningAmendmentRequestV04"/> is required.
    /// </summary>
    [DataMember(Name=AccountOpeningAmendmentRequestV04.XmlTag)]
    public required AccountOpeningAmendmentRequestV04 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(AccountOpeningAmendmentRequestV04.XmlTag);
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
