﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CorporateActionNotification002V07.  ISO2002 ID# _sb-385wqEeazcsnODTksnQ.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.seev.CorporateActionNotification002V07>;

namespace BeneficialStrategies.Iso20022.seev;


/// <summary>
/// This record is an implementation of the seev.031.002.07 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account servicer sends the CorporateActionNotification message to an account owner or its designated agent to notify details of a corporate action event and optionally account information, eligible balance and entitlements.|
/// It may also include possible elections or choices available to the account owner. The account servicer can initially send the CorporateActionNotification message as a preliminary advice, subsequently replaced by another CorporateActionNotification message with complete or confirmed information.|
/// It may also be sent to an account owner or its designated agent, to remind of event details and/or of missing or incomplete instructions for a corporate action event.
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent (the sub-function of the message is Duplicate),
/// - provide a third party with a copy of a message for information (the sub-function of the message is Copy),
/// - re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate),
/// using the relevant elements in the business application header (BAH).
/// </summary>
[Serializable]
[Description(@"Scope|An account servicer sends the CorporateActionNotification message to an account owner or its designated agent to notify details of a corporate action event and optionally account information, eligible balance and entitlements.||It may also include possible elections or choices available to the account owner. The account servicer can initially send the CorporateActionNotification message as a preliminary advice, subsequently replaced by another CorporateActionNotification message with complete or confirmed information.||It may also be sent to an account owner or its designated agent, to remind of event details and/or of missing or incomplete instructions for a corporate action event.|Usage|The message may also be used to:|- re-send a message previously sent (the sub-function of the message is Duplicate),|- provide a third party with a copy of a message for information (the sub-function of the message is Copy),|- re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate),|using the relevant elements in the business application header (BAH).")]
public partial record CorporateActionNotification002V07 : IOuterRecord<CorporateActionNotification002V07,CorporateActionNotification002V07Document>
    ,IIsoXmlSerilizable<CorporateActionNotification002V07>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.031.002.07";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CorpActnNtfctn";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => CorporateActionNotification002V07Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Page number of the message and continuation indicator to indicate that the multi-parts notification is to continue or that the message is the last page of the multi-parts notification.
    /// </summary>
    [IsoId("_sb-4GZwqEeazcsnODTksnQ")]
    [Description(@"Page number of the message and continuation indicator to indicate that the multi-parts notification is to continue or that the message is the last page of the multi-parts notification.")]
    [DataMember(Name="Pgntn")]
    [XmlElement(ElementName="Pgntn")]
    public Pagination? Pagination { get; init; }
    
    /// <summary>
    /// General information about the event notification type, status and contents.
    /// </summary>
    [IsoId("_sb-4G5wqEeazcsnODTksnQ")]
    [Description(@"General information about the event notification type, status and contents.")]
    [DataMember(Name="NtfctnGnlInf")]
    [XmlElement(ElementName="NtfctnGnlInf")]
    [Required]
    public required CorporateActionNotification6 NotificationGeneralInformation { get; init; }
    
    /// <summary>
    /// Identification of a previously sent notification document.
    /// </summary>
    [IsoId("_sb-4HZwqEeazcsnODTksnQ")]
    [Description(@"Identification of a previously sent notification document.")]
    [DataMember(Name="PrvsNtfctnId")]
    [XmlElement(ElementName="PrvsNtfctnId")]
    public DocumentIdentification37? PreviousNotificationIdentification { get; init; }
    
    /// <summary>
    /// Identification of a related instruction document.
    /// </summary>
    [IsoId("_sb-4H5wqEeazcsnODTksnQ")]
    [Description(@"Identification of a related instruction document.")]
    [DataMember(Name="InstrId")]
    [XmlElement(ElementName="InstrId")]
    public DocumentIdentification17? InstructionIdentification { get; init; }
    
    /// <summary>
    /// Identification of other documents as well as the document number.
    /// </summary>
    [IsoId("_sb-4IZwqEeazcsnODTksnQ")]
    [Description(@"Identification of other documents as well as the document number.")]
    [DataMember(Name="OthrDocId")]
    [XmlElement(ElementName="OthrDocId")]
    public DocumentIdentification38? OtherDocumentIdentification { get; init; }
    
    /// <summary>
    /// Identification of an other corporate action event that needs to be closely linked to the processing of the event notified in this document.
    /// </summary>
    [IsoId("_sb-4I5wqEeazcsnODTksnQ")]
    [Description(@"Identification of an other corporate action event that needs to be closely linked to the processing of the event notified in this document.")]
    [DataMember(Name="EvtsLkg")]
    [XmlElement(ElementName="EvtsLkg")]
    public CorporateActionEventReference4? EventsLinkage { get; init; }
    
    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_sb-4JZwqEeazcsnODTksnQ")]
    [Description(@"General information about the corporate action event.")]
    [DataMember(Name="CorpActnGnlInf")]
    [XmlElement(ElementName="CorpActnGnlInf")]
    [Required]
    public required CorporateActionGeneralInformation113 CorporateActionGeneralInformation { get; init; }
    
    /// <summary>
    /// General information about the safekeeping account, owner and account balance.
    /// </summary>
    [IsoId("_sb-4J5wqEeazcsnODTksnQ")]
    [Description(@"General information about the safekeeping account, owner and account balance.")]
    [DataMember(Name="AcctDtls")]
    [XmlElement(ElementName="AcctDtls")]
    [Required]
    public required AccountIdentification36Choice_ AccountDetails { get; init; }
    
    /// <summary>
    /// Provides details on rights credited to the account as for instance trading period, expiry date, renounceability.
    /// </summary>
    [IsoId("_sb-4KZwqEeazcsnODTksnQ")]
    [Description(@"Provides details on rights credited to the account as for instance trading period, expiry date, renounceability.")]
    [DataMember(Name="IntrmdtScty")]
    [XmlElement(ElementName="IntrmdtScty")]
    public FinancialInstrumentAttributes73? IntermediateSecurity { get; init; }
    
    /// <summary>
    /// Information about the corporate action event.
    /// </summary>
    [IsoId("_sb-4K5wqEeazcsnODTksnQ")]
    [Description(@"Information about the corporate action event.")]
    [DataMember(Name="CorpActnDtls")]
    [XmlElement(ElementName="CorpActnDtls")]
    public CorporateAction40? CorporateActionDetails { get; init; }
    
    /// <summary>
    /// Information about the corporate action option.
    /// </summary>
    [IsoId("_sb-4LZwqEeazcsnODTksnQ")]
    [Description(@"Information about the corporate action option.")]
    [DataMember(Name="CorpActnOptnDtls")]
    [XmlElement(ElementName="CorpActnOptnDtls")]
    public CorporateActionOption133? CorporateActionOptionDetails { get; init; }
    
    /// <summary>
    /// Provides additional information.
    /// </summary>
    [IsoId("_sb-4L5wqEeazcsnODTksnQ")]
    [Description(@"Provides additional information.")]
    [DataMember(Name="AddtlInf")]
    [XmlElement(ElementName="AddtlInf")]
    public CorporateActionNarrative41? AdditionalInformation { get; init; }
    
    /// <summary>
    /// Party appointed to administer the event on behalf of the issuer company/offeror. The party may be contacted for more information about the event.
    /// </summary>
    [IsoId("_sb-4MZwqEeazcsnODTksnQ")]
    [Description(@"Party appointed to administer the event on behalf of the issuer company/offeror. The party may be contacted for more information about the event.")]
    [DataMember(Name="IssrAgt")]
    [XmlElement(ElementName="IssrAgt")]
    public PartyIdentification104Choice_? IssuerAgent { get; init; }
    
    /// <summary>
    /// Agent (principal or fiscal paying agent) appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.
    /// </summary>
    [IsoId("_sb-4M5wqEeazcsnODTksnQ")]
    [Description(@"Agent (principal or fiscal paying agent) appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.")]
    [DataMember(Name="PngAgt")]
    [XmlElement(ElementName="PngAgt")]
    public PartyIdentification104Choice_? PayingAgent { get; init; }
    
    /// <summary>
    /// Sub-agent appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.
    /// </summary>
    [IsoId("_sb-4NZwqEeazcsnODTksnQ")]
    [Description(@"Sub-agent appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.")]
    [DataMember(Name="SubPngAgt")]
    [XmlElement(ElementName="SubPngAgt")]
    public PartyIdentification104Choice_? SubPayingAgent { get; init; }
    
    /// <summary>
    /// Party/agent responsible for maintaining the register of a security.
    /// </summary>
    [IsoId("_sb-4N5wqEeazcsnODTksnQ")]
    [Description(@"Party/agent responsible for maintaining the register of a security.")]
    [DataMember(Name="Regar")]
    [XmlElement(ElementName="Regar")]
    public PartyIdentification104Choice_? Registrar { get; init; }
    
    /// <summary>
    /// A broker-dealer responsible for reselling to new investors securities (usually bonds) that have been tendered for purchase by their owner.
    /// </summary>
    [IsoId("_sb-4OZwqEeazcsnODTksnQ")]
    [Description(@"A broker-dealer responsible for reselling to new investors securities (usually bonds) that have been tendered for purchase by their owner.")]
    [DataMember(Name="RsellngAgt")]
    [XmlElement(ElementName="RsellngAgt")]
    public PartyIdentification104Choice_? ResellingAgent { get; init; }
    
    /// <summary>
    /// A trust company, bank or similar financial institution assigned by an issuer to accept presentations of instruments, usually bonds, for transfer and or exchange.
    /// </summary>
    [IsoId("_sb-4O5wqEeazcsnODTksnQ")]
    [Description(@"A trust company, bank or similar financial institution assigned by an issuer to accept presentations of instruments, usually bonds, for transfer and or exchange.")]
    [DataMember(Name="PhysSctiesAgt")]
    [XmlElement(ElementName="PhysSctiesAgt")]
    public PartyIdentification104Choice_? PhysicalSecuritiesAgent { get; init; }
    
    /// <summary>
    /// A trust company, bank or similar financial institution who acts on behalf of an out of town agent or event agent where securities can be delivered in person.
    /// </summary>
    [IsoId("_sb-4PZwqEeazcsnODTksnQ")]
    [Description(@"A trust company, bank or similar financial institution who acts on behalf of an out of town agent or event agent where securities can be delivered in person.")]
    [DataMember(Name="DrpAgt")]
    [XmlElement(ElementName="DrpAgt")]
    public PartyIdentification104Choice_? DropAgent { get; init; }
    
    /// <summary>
    /// A trust company, bank or similar financial institution assigned by an issuer to maintain records of investors and account balances and transactions for the consent of a material change.
    /// </summary>
    [IsoId("_sb-4P5wqEeazcsnODTksnQ")]
    [Description(@"A trust company, bank or similar financial institution assigned by an issuer to maintain records of investors and account balances and transactions for the consent of a material change.")]
    [DataMember(Name="SlctnAgt")]
    [XmlElement(ElementName="SlctnAgt")]
    public PartyIdentification104Choice_? SolicitationAgent { get; init; }
    
    /// <summary>
    /// A trust company, bank or similar financial institution assigned by an Issuer to provide information and copies of the offering documentation.
    /// </summary>
    [IsoId("_sb-4QZwqEeazcsnODTksnQ")]
    [Description(@"A trust company, bank or similar financial institution assigned by an Issuer to provide information and copies of the offering documentation.")]
    [DataMember(Name="InfAgt")]
    [XmlElement(ElementName="InfAgt")]
    public PartyIdentification104Choice_? InformationAgent { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_sb-4Q5wqEeazcsnODTksnQ")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CorporateActionNotification002V07Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CorporateActionNotification002V07Document ToDocument()
    {
        return new CorporateActionNotification002V07Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("CorpActnNtfctn");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        if (Pagination is Pagination PaginationValue)
        {
            writer.WriteStartElement(null, "Pgntn", xmlNamespace );
            PaginationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "NtfctnGnlInf", xmlNamespace );
        NotificationGeneralInformation.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (PreviousNotificationIdentification is DocumentIdentification37 PreviousNotificationIdentificationValue)
        {
            writer.WriteStartElement(null, "PrvsNtfctnId", xmlNamespace );
            PreviousNotificationIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InstructionIdentification is DocumentIdentification17 InstructionIdentificationValue)
        {
            writer.WriteStartElement(null, "InstrId", xmlNamespace );
            InstructionIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OtherDocumentIdentification is DocumentIdentification38 OtherDocumentIdentificationValue)
        {
            writer.WriteStartElement(null, "OthrDocId", xmlNamespace );
            OtherDocumentIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (EventsLinkage is CorporateActionEventReference4 EventsLinkageValue)
        {
            writer.WriteStartElement(null, "EvtsLkg", xmlNamespace );
            EventsLinkageValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "CorpActnGnlInf", xmlNamespace );
        CorporateActionGeneralInformation.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "AcctDtls", xmlNamespace );
        AccountDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (IntermediateSecurity is FinancialInstrumentAttributes73 IntermediateSecurityValue)
        {
            writer.WriteStartElement(null, "IntrmdtScty", xmlNamespace );
            IntermediateSecurityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CorporateActionDetails is CorporateAction40 CorporateActionDetailsValue)
        {
            writer.WriteStartElement(null, "CorpActnDtls", xmlNamespace );
            CorporateActionDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CorporateActionOptionDetails is CorporateActionOption133 CorporateActionOptionDetailsValue)
        {
            writer.WriteStartElement(null, "CorpActnOptnDtls", xmlNamespace );
            CorporateActionOptionDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AdditionalInformation is CorporateActionNarrative41 AdditionalInformationValue)
        {
            writer.WriteStartElement(null, "AddtlInf", xmlNamespace );
            AdditionalInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (IssuerAgent is PartyIdentification104Choice_ IssuerAgentValue)
        {
            writer.WriteStartElement(null, "IssrAgt", xmlNamespace );
            IssuerAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PayingAgent is PartyIdentification104Choice_ PayingAgentValue)
        {
            writer.WriteStartElement(null, "PngAgt", xmlNamespace );
            PayingAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SubPayingAgent is PartyIdentification104Choice_ SubPayingAgentValue)
        {
            writer.WriteStartElement(null, "SubPngAgt", xmlNamespace );
            SubPayingAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Registrar is PartyIdentification104Choice_ RegistrarValue)
        {
            writer.WriteStartElement(null, "Regar", xmlNamespace );
            RegistrarValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ResellingAgent is PartyIdentification104Choice_ ResellingAgentValue)
        {
            writer.WriteStartElement(null, "RsellngAgt", xmlNamespace );
            ResellingAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PhysicalSecuritiesAgent is PartyIdentification104Choice_ PhysicalSecuritiesAgentValue)
        {
            writer.WriteStartElement(null, "PhysSctiesAgt", xmlNamespace );
            PhysicalSecuritiesAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DropAgent is PartyIdentification104Choice_ DropAgentValue)
        {
            writer.WriteStartElement(null, "DrpAgt", xmlNamespace );
            DropAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SolicitationAgent is PartyIdentification104Choice_ SolicitationAgentValue)
        {
            writer.WriteStartElement(null, "SlctnAgt", xmlNamespace );
            SolicitationAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InformationAgent is PartyIdentification104Choice_ InformationAgentValue)
        {
            writer.WriteStartElement(null, "InfAgt", xmlNamespace );
            InformationAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CorporateActionNotification002V07 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CorporateActionNotification002V07"/>.
/// </summary>
[Serializable]
public partial record CorporateActionNotification002V07Document : IOuterDocument<CorporateActionNotification002V07>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.031.002.07";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CorporateActionNotification002V07"/> is required.
    /// </summary>
    [DataMember(Name=CorporateActionNotification002V07.XmlTag)]
    public required CorporateActionNotification002V07 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(CorporateActionNotification002V07.XmlTag);
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
