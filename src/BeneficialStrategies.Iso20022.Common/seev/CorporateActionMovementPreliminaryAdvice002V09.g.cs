﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CorporateActionMovementPreliminaryAdvice002V09.  ISO2002 ID# _k9dC483xEee5nJBZsW8MFQ.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.seev.CorporateActionMovementPreliminaryAdvice002V09>;

namespace BeneficialStrategies.Iso20022.seev;


/// <summary>
/// This record is an implementation of the seev.035.002.09 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account servicer sends the CorporateActionMovementPreliminaryAdvice message to an account owner or its designated agent to pre-advise upcoming posting or reversal of securities and/or cash postings.
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent (the sub-function of the message is Duplicate),
/// - provide a third party with a copy of a message for information (the sub-function of the message is Copy),
/// - re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate),
/// using the relevant elements in the business application header (BAH).
/// </summary>
[Serializable]
[Description(@"Scope|An account servicer sends the CorporateActionMovementPreliminaryAdvice message to an account owner or its designated agent to pre-advise upcoming posting or reversal of securities and/or cash postings.|Usage|The message may also be used to:|- re-send a message previously sent (the sub-function of the message is Duplicate),|- provide a third party with a copy of a message for information (the sub-function of the message is Copy),|- re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate),|using the relevant elements in the business application header (BAH).")]
public partial record CorporateActionMovementPreliminaryAdvice002V09 : IOuterRecord<CorporateActionMovementPreliminaryAdvice002V09,CorporateActionMovementPreliminaryAdvice002V09Document>
    ,IIsoXmlSerilizable<CorporateActionMovementPreliminaryAdvice002V09>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.035.002.09";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CorpActnMvmntPrlimryAdvc";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => CorporateActionMovementPreliminaryAdvice002V09Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Page number of the message and continuation indicator to indicate that the multi-part preliminary advice is to continue or that the message is the last page of the multi-part preliminary advice.
    /// </summary>
    [IsoId("_k9dC8c3xEee5nJBZsW8MFQ")]
    [Description(@"Page number of the message and continuation indicator to indicate that the multi-part preliminary advice is to continue or that the message is the last page of the multi-part preliminary advice.")]
    [DataMember(Name="Pgntn")]
    [XmlElement(ElementName="Pgntn")]
    public Pagination1? Pagination { get; init; }
    
    /// <summary>
    /// General information about the movement preliminary advice document.
    /// </summary>
    [IsoId("_k9dC883xEee5nJBZsW8MFQ")]
    [Description(@"General information about the movement preliminary advice document.")]
    [DataMember(Name="MvmntPrlimryAdvcGnlInf")]
    [XmlElement(ElementName="MvmntPrlimryAdvcGnlInf")]
    [Required]
    public required CorporateActionPreliminaryAdviceType2 MovementPreliminaryAdviceGeneralInformation { get; init; }
    
    /// <summary>
    /// Identification of a previously sent movement preliminary advice document.
    /// </summary>
    [IsoId("_k9dC9c3xEee5nJBZsW8MFQ")]
    [Description(@"Identification of a previously sent movement preliminary advice document.")]
    [DataMember(Name="PrvsMvmntPrlimryAdvcId")]
    [XmlElement(ElementName="PrvsMvmntPrlimryAdvcId")]
    public DocumentIdentification37? PreviousMovementPreliminaryAdviceIdentification { get; init; }
    
    /// <summary>
    /// Identification of a previously sent notification document.
    /// </summary>
    [IsoId("_k9dC983xEee5nJBZsW8MFQ")]
    [Description(@"Identification of a previously sent notification document.")]
    [DataMember(Name="NtfctnId")]
    [XmlElement(ElementName="NtfctnId")]
    public DocumentIdentification37? NotificationIdentification { get; init; }
    
    /// <summary>
    /// Identification of a previously sent movement confirmation document.
    /// </summary>
    [IsoId("_k9dC-c3xEee5nJBZsW8MFQ")]
    [Description(@"Identification of a previously sent movement confirmation document.")]
    [DataMember(Name="MvmntConfId")]
    [XmlElement(ElementName="MvmntConfId")]
    public DocumentIdentification37? MovementConfirmationIdentification { get; init; }
    
    /// <summary>
    /// Identification of a related instruction document.
    /// </summary>
    [IsoId("_k9dC-83xEee5nJBZsW8MFQ")]
    [Description(@"Identification of a related instruction document.")]
    [DataMember(Name="InstrId")]
    [XmlElement(ElementName="InstrId")]
    public DocumentIdentification17? InstructionIdentification { get; init; }
    
    /// <summary>
    /// Identification of other documents as well as the document number.
    /// </summary>
    [IsoId("_k9dC_c3xEee5nJBZsW8MFQ")]
    [Description(@"Identification of other documents as well as the document number.")]
    [DataMember(Name="OthrDocId")]
    [XmlElement(ElementName="OthrDocId")]
    public DocumentIdentification38? OtherDocumentIdentification { get; init; }
    
    /// <summary>
    /// Identification of another corporate action event that needs to be closely linked to the processing of the event notified in this document.
    /// </summary>
    [IsoId("_k9dC_83xEee5nJBZsW8MFQ")]
    [Description(@"Identification of another corporate action event that needs to be closely linked to the processing of the event notified in this document.")]
    [DataMember(Name="EvtsLkg")]
    [XmlElement(ElementName="EvtsLkg")]
    public CorporateActionEventReference4? EventsLinkage { get; init; }
    
    /// <summary>
    /// Reason for the reversal.
    /// </summary>
    [IsoId("_k9dDAc3xEee5nJBZsW8MFQ")]
    [Description(@"Reason for the reversal.")]
    [DataMember(Name="RvslRsn")]
    [XmlElement(ElementName="RvslRsn")]
    public CorporateActionReversalReason4? ReversalReason { get; init; }
    
    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_k9dDA83xEee5nJBZsW8MFQ")]
    [Description(@"General information about the corporate action event.")]
    [DataMember(Name="CorpActnGnlInf")]
    [XmlElement(ElementName="CorpActnGnlInf")]
    [Required]
    public required CorporateActionGeneralInformation132 CorporateActionGeneralInformation { get; init; }
    
    /// <summary>
    /// General information about the safekeeping account, owner and account balance.
    /// </summary>
    [IsoId("_k9dDBc3xEee5nJBZsW8MFQ")]
    [Description(@"General information about the safekeeping account, owner and account balance.")]
    [DataMember(Name="AcctDtls")]
    [XmlElement(ElementName="AcctDtls")]
    [Required]
    public required AccountIdentification36Choice_ AccountDetails { get; init; }
    
    /// <summary>
    /// Information about the corporate action event.
    /// </summary>
    [IsoId("_k9dDB83xEee5nJBZsW8MFQ")]
    [Description(@"Information about the corporate action event.")]
    [DataMember(Name="CorpActnDtls")]
    [XmlElement(ElementName="CorpActnDtls")]
    public CorporateAction49? CorporateActionDetails { get; init; }
    
    /// <summary>
    /// Information about the corporate action option.
    /// </summary>
    [IsoId("_k9dDCc3xEee5nJBZsW8MFQ")]
    [Description(@"Information about the corporate action option.")]
    [DataMember(Name="CorpActnMvmntDtls")]
    [XmlElement(ElementName="CorpActnMvmntDtls")]
    public CorporateActionOption148? CorporateActionMovementDetails { get; init; }
    
    /// <summary>
    /// Provides additional information.
    /// </summary>
    [IsoId("_k9dDC83xEee5nJBZsW8MFQ")]
    [Description(@"Provides additional information.")]
    [DataMember(Name="AddtlInf")]
    [XmlElement(ElementName="AddtlInf")]
    public CorporateActionNarrative37? AdditionalInformation { get; init; }
    
    /// <summary>
    /// Party appointed to administer the event on behalf of the issuer company/offeror. The party may be contacted for more information about the event.
    /// </summary>
    [IsoId("_k9dDDc3xEee5nJBZsW8MFQ")]
    [Description(@"Party appointed to administer the event on behalf of the issuer company/offeror. The party may be contacted for more information about the event.")]
    [DataMember(Name="IssrAgt")]
    [XmlElement(ElementName="IssrAgt")]
    public PartyIdentification104Choice_? IssuerAgent { get; init; }
    
    /// <summary>
    /// Agent (principal or fiscal paying agent) appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.
    /// </summary>
    [IsoId("_k9dDD83xEee5nJBZsW8MFQ")]
    [Description(@"Agent (principal or fiscal paying agent) appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.")]
    [DataMember(Name="PngAgt")]
    [XmlElement(ElementName="PngAgt")]
    public PartyIdentification104Choice_? PayingAgent { get; init; }
    
    /// <summary>
    /// Sub-agent appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.
    /// </summary>
    [IsoId("_k9dDEc3xEee5nJBZsW8MFQ")]
    [Description(@"Sub-agent appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.")]
    [DataMember(Name="SubPngAgt")]
    [XmlElement(ElementName="SubPngAgt")]
    public PartyIdentification104Choice_? SubPayingAgent { get; init; }
    
    /// <summary>
    /// Party/agent responsible for maintaining the register of a security.
    /// </summary>
    [IsoId("_k9dDE83xEee5nJBZsW8MFQ")]
    [Description(@"Party/agent responsible for maintaining the register of a security.")]
    [DataMember(Name="Regar")]
    [XmlElement(ElementName="Regar")]
    public PartyIdentification104Choice_? Registrar { get; init; }
    
    /// <summary>
    /// A broker-dealer responsible for reselling to new investors securities (usually bonds) that have been tendered for purchase by their owner.
    /// </summary>
    [IsoId("_k9dDFc3xEee5nJBZsW8MFQ")]
    [Description(@"A broker-dealer responsible for reselling to new investors securities (usually bonds) that have been tendered for purchase by their owner.")]
    [DataMember(Name="RsellngAgt")]
    [XmlElement(ElementName="RsellngAgt")]
    public PartyIdentification104Choice_? ResellingAgent { get; init; }
    
    /// <summary>
    /// A trust company, bank or similar financial institution assigned by an issuer to accept presentations of instruments, usually bonds, for transfer and or exchange.
    /// </summary>
    [IsoId("_k9dDF83xEee5nJBZsW8MFQ")]
    [Description(@"A trust company, bank or similar financial institution assigned by an issuer to accept presentations of instruments, usually bonds, for transfer and or exchange.")]
    [DataMember(Name="PhysSctiesAgt")]
    [XmlElement(ElementName="PhysSctiesAgt")]
    public PartyIdentification104Choice_? PhysicalSecuritiesAgent { get; init; }
    
    /// <summary>
    /// A trust company, bank or similar financial institution that acts on behalf of an out-of-town agent or event agent where securities can be delivered in person.
    /// </summary>
    [IsoId("_k9dDGc3xEee5nJBZsW8MFQ")]
    [Description(@"A trust company, bank or similar financial institution that acts on behalf of an out-of-town agent or event agent where securities can be delivered in person.")]
    [DataMember(Name="DrpAgt")]
    [XmlElement(ElementName="DrpAgt")]
    public PartyIdentification104Choice_? DropAgent { get; init; }
    
    /// <summary>
    /// A trust company, bank or similar financial institution assigned by an issuer to maintain records of investors and account balances and transactions for the consent of a material change.
    /// </summary>
    [IsoId("_k9dDG83xEee5nJBZsW8MFQ")]
    [Description(@"A trust company, bank or similar financial institution assigned by an issuer to maintain records of investors and account balances and transactions for the consent of a material change.")]
    [DataMember(Name="SlctnAgt")]
    [XmlElement(ElementName="SlctnAgt")]
    public PartyIdentification104Choice_? SolicitationAgent { get; init; }
    
    /// <summary>
    /// A trust company, bank or similar financial institution assigned by an Issuer to provide information and copies of the offering documentation.
    /// </summary>
    [IsoId("_k9dDHc3xEee5nJBZsW8MFQ")]
    [Description(@"A trust company, bank or similar financial institution assigned by an Issuer to provide information and copies of the offering documentation.")]
    [DataMember(Name="InfAgt")]
    [XmlElement(ElementName="InfAgt")]
    public PartyIdentification104Choice_? InformationAgent { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_k9dDH83xEee5nJBZsW8MFQ")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CorporateActionMovementPreliminaryAdvice002V09Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CorporateActionMovementPreliminaryAdvice002V09Document ToDocument()
    {
        return new CorporateActionMovementPreliminaryAdvice002V09Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("CorpActnMvmntPrlimryAdvc");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        if (Pagination is Pagination1 PaginationValue)
        {
            writer.WriteStartElement(null, "Pgntn", xmlNamespace );
            PaginationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "MvmntPrlimryAdvcGnlInf", xmlNamespace );
        MovementPreliminaryAdviceGeneralInformation.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (PreviousMovementPreliminaryAdviceIdentification is DocumentIdentification37 PreviousMovementPreliminaryAdviceIdentificationValue)
        {
            writer.WriteStartElement(null, "PrvsMvmntPrlimryAdvcId", xmlNamespace );
            PreviousMovementPreliminaryAdviceIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (NotificationIdentification is DocumentIdentification37 NotificationIdentificationValue)
        {
            writer.WriteStartElement(null, "NtfctnId", xmlNamespace );
            NotificationIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (MovementConfirmationIdentification is DocumentIdentification37 MovementConfirmationIdentificationValue)
        {
            writer.WriteStartElement(null, "MvmntConfId", xmlNamespace );
            MovementConfirmationIdentificationValue.Serialize(writer, xmlNamespace);
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
        if (ReversalReason is CorporateActionReversalReason4 ReversalReasonValue)
        {
            writer.WriteStartElement(null, "RvslRsn", xmlNamespace );
            ReversalReasonValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "CorpActnGnlInf", xmlNamespace );
        CorporateActionGeneralInformation.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "AcctDtls", xmlNamespace );
        AccountDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (CorporateActionDetails is CorporateAction49 CorporateActionDetailsValue)
        {
            writer.WriteStartElement(null, "CorpActnDtls", xmlNamespace );
            CorporateActionDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CorporateActionMovementDetails is CorporateActionOption148 CorporateActionMovementDetailsValue)
        {
            writer.WriteStartElement(null, "CorpActnMvmntDtls", xmlNamespace );
            CorporateActionMovementDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AdditionalInformation is CorporateActionNarrative37 AdditionalInformationValue)
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
    public static CorporateActionMovementPreliminaryAdvice002V09 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CorporateActionMovementPreliminaryAdvice002V09"/>.
/// </summary>
[Serializable]
public partial record CorporateActionMovementPreliminaryAdvice002V09Document : IOuterDocument<CorporateActionMovementPreliminaryAdvice002V09>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.035.002.09";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CorporateActionMovementPreliminaryAdvice002V09"/> is required.
    /// </summary>
    [DataMember(Name=CorporateActionMovementPreliminaryAdvice002V09.XmlTag)]
    public required CorporateActionMovementPreliminaryAdvice002V09 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(CorporateActionMovementPreliminaryAdvice002V09.XmlTag);
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
