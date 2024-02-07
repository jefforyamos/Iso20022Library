﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CorporateActionMovementPreliminaryAdviceCancellationAdvice002V12.  ISO2002 ID# _SeCvHl99Ee262vCSVgjImg.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.seev.CorporateActionMovementPreliminaryAdviceCancellationAdvice002V12>;

namespace BeneficialStrategies.Iso20022.seev;


/// <summary>
/// This record is an implementation of the seev.044.002.12 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The CorporateActionMovementPreliminaryAdviceCancellationAdvice message is sent by an account servicer to an account owner or its designated agent to cancel a previously announced CorporateActionMovementPreliminaryAdvice.
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent (the sub-function of the message is Duplicate),
/// - provide a third party with a copy of a message for information (the sub-function of the message is Copy),
/// - re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate), using the relevant elements in the business application header (BAH).
/// </summary>
[Serializable]
[Description(@"Scope|The CorporateActionMovementPreliminaryAdviceCancellationAdvice message is sent by an account servicer to an account owner or its designated agent to cancel a previously announced CorporateActionMovementPreliminaryAdvice.|Usage|The message may also be used to:|- re-send a message previously sent (the sub-function of the message is Duplicate),|- provide a third party with a copy of a message for information (the sub-function of the message is Copy),|- re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate), using the relevant elements in the business application header (BAH).")]
public partial record CorporateActionMovementPreliminaryAdviceCancellationAdvice002V12 : IOuterRecord<CorporateActionMovementPreliminaryAdviceCancellationAdvice002V12,CorporateActionMovementPreliminaryAdviceCancellationAdvice002V12Document>
    ,IIsoXmlSerilizable<CorporateActionMovementPreliminaryAdviceCancellationAdvice002V12>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.044.002.12";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CorpActnMvmntPrlimryAdvcCxlAdvc";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => CorporateActionMovementPreliminaryAdviceCancellationAdvice002V12Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Identification of a previously sent movement preliminary advice document.
    /// </summary>
    [IsoId("_SeCvI199Ee262vCSVgjImg")]
    [Description(@"Identification of a previously sent movement preliminary advice document.")]
    [DataMember(Name="MvmntPrlimryAdvcId")]
    [XmlElement(ElementName="MvmntPrlimryAdvcId")]
    [Required]
    public required DocumentIdentification37 MovementPreliminaryAdviceIdentification { get; init; }
    
    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_SeCvJV99Ee262vCSVgjImg")]
    [Description(@"General information about the corporate action event.")]
    [DataMember(Name="CorpActnGnlInf")]
    [XmlElement(ElementName="CorpActnGnlInf")]
    [Required]
    public required CorporateActionGeneralInformation150 CorporateActionGeneralInformation { get; init; }
    
    /// <summary>
    /// General information about the safekeeping account and the account owner.
    /// </summary>
    [IsoId("_SeCvJ199Ee262vCSVgjImg")]
    [Description(@"General information about the safekeeping account and the account owner.")]
    [DataMember(Name="AcctDtls")]
    [XmlElement(ElementName="AcctDtls")]
    [Required]
    public required AccountIdentification50Choice_ AccountDetails { get; init; }
    
    /// <summary>
    /// Information about the corporate action event.
    /// </summary>
    [IsoId("_SeCvKV99Ee262vCSVgjImg")]
    [Description(@"Information about the corporate action event.")]
    [DataMember(Name="CorpActnDtls")]
    [XmlElement(ElementName="CorpActnDtls")]
    public CorporateAction76? CorporateActionDetails { get; init; }
    
    /// <summary>
    /// Party appointed to administer the event on behalf of the issuer company/offeror. The party may be contacted for more information about the event.
    /// </summary>
    [IsoId("_SeCvK199Ee262vCSVgjImg")]
    [Description(@"Party appointed to administer the event on behalf of the issuer company/offeror. The party may be contacted for more information about the event.")]
    [DataMember(Name="IssrAgt")]
    [XmlElement(ElementName="IssrAgt")]
    public PartyIdentification137Choice_? IssuerAgent { get; init; }
    
    /// <summary>
    /// Agent (principal or fiscal paying agent) appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.
    /// </summary>
    [IsoId("_SeCvLV99Ee262vCSVgjImg")]
    [Description(@"Agent (principal or fiscal paying agent) appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.")]
    [DataMember(Name="PngAgt")]
    [XmlElement(ElementName="PngAgt")]
    public PartyIdentification137Choice_? PayingAgent { get; init; }
    
    /// <summary>
    /// Sub-agent appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.
    /// </summary>
    [IsoId("_SeCvL199Ee262vCSVgjImg")]
    [Description(@"Sub-agent appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.")]
    [DataMember(Name="SubPngAgt")]
    [XmlElement(ElementName="SubPngAgt")]
    public PartyIdentification137Choice_? SubPayingAgent { get; init; }
    
    /// <summary>
    /// Party/agent responsible for maintaining the register of a security.
    /// </summary>
    [IsoId("_SeCvMV99Ee262vCSVgjImg")]
    [Description(@"Party/agent responsible for maintaining the register of a security.")]
    [DataMember(Name="Regar")]
    [XmlElement(ElementName="Regar")]
    public PartyIdentification137Choice_? Registrar { get; init; }
    
    /// <summary>
    /// Broker-dealer responsible for reselling to new investors securities (usually bonds) that have been tendered for purchase by their owner.
    /// </summary>
    [IsoId("_SeCvM199Ee262vCSVgjImg")]
    [Description(@"Broker-dealer responsible for reselling to new investors securities (usually bonds) that have been tendered for purchase by their owner.")]
    [DataMember(Name="RsellngAgt")]
    [XmlElement(ElementName="RsellngAgt")]
    public PartyIdentification137Choice_? ResellingAgent { get; init; }
    
    /// <summary>
    /// Trust company, bank or similar financial institution assigned by an issuer to accept presentations of instruments, usually bonds, for transfer and or exchange.
    /// </summary>
    [IsoId("_SeCvNV99Ee262vCSVgjImg")]
    [Description(@"Trust company, bank or similar financial institution assigned by an issuer to accept presentations of instruments, usually bonds, for transfer and or exchange.")]
    [DataMember(Name="PhysSctiesAgt")]
    [XmlElement(ElementName="PhysSctiesAgt")]
    public PartyIdentification137Choice_? PhysicalSecuritiesAgent { get; init; }
    
    /// <summary>
    /// Trust company, bank or similar financial institution that acts on behalf of an out-of-town agent or event agent where securities can be delivered in person.
    /// </summary>
    [IsoId("_SeCvN199Ee262vCSVgjImg")]
    [Description(@"Trust company, bank or similar financial institution that acts on behalf of an out-of-town agent or event agent where securities can be delivered in person.")]
    [DataMember(Name="DrpAgt")]
    [XmlElement(ElementName="DrpAgt")]
    public PartyIdentification137Choice_? DropAgent { get; init; }
    
    /// <summary>
    /// Trust company, bank or similar financial institution assigned by an issuer to maintain records of investors and account balances and transactions for the consent of a material change.
    /// </summary>
    [IsoId("_SeCvOV99Ee262vCSVgjImg")]
    [Description(@"Trust company, bank or similar financial institution assigned by an issuer to maintain records of investors and account balances and transactions for the consent of a material change.")]
    [DataMember(Name="SlctnAgt")]
    [XmlElement(ElementName="SlctnAgt")]
    public PartyIdentification137Choice_? SolicitationAgent { get; init; }
    
    /// <summary>
    /// Trust company, bank or similar financial institution assigned by an Issuer to provide information and copies of the offering documentation.
    /// </summary>
    [IsoId("_SeCvO199Ee262vCSVgjImg")]
    [Description(@"Trust company, bank or similar financial institution assigned by an Issuer to provide information and copies of the offering documentation.")]
    [DataMember(Name="InfAgt")]
    [XmlElement(ElementName="InfAgt")]
    public PartyIdentification137Choice_? InformationAgent { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_SeCvPV99Ee262vCSVgjImg")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CorporateActionMovementPreliminaryAdviceCancellationAdvice002V12Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CorporateActionMovementPreliminaryAdviceCancellationAdvice002V12Document ToDocument()
    {
        return new CorporateActionMovementPreliminaryAdviceCancellationAdvice002V12Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("CorpActnMvmntPrlimryAdvcCxlAdvc");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "MvmntPrlimryAdvcId", xmlNamespace );
        MovementPreliminaryAdviceIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "CorpActnGnlInf", xmlNamespace );
        CorporateActionGeneralInformation.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "AcctDtls", xmlNamespace );
        AccountDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (CorporateActionDetails is CorporateAction76 CorporateActionDetailsValue)
        {
            writer.WriteStartElement(null, "CorpActnDtls", xmlNamespace );
            CorporateActionDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (IssuerAgent is PartyIdentification137Choice_ IssuerAgentValue)
        {
            writer.WriteStartElement(null, "IssrAgt", xmlNamespace );
            IssuerAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PayingAgent is PartyIdentification137Choice_ PayingAgentValue)
        {
            writer.WriteStartElement(null, "PngAgt", xmlNamespace );
            PayingAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SubPayingAgent is PartyIdentification137Choice_ SubPayingAgentValue)
        {
            writer.WriteStartElement(null, "SubPngAgt", xmlNamespace );
            SubPayingAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Registrar is PartyIdentification137Choice_ RegistrarValue)
        {
            writer.WriteStartElement(null, "Regar", xmlNamespace );
            RegistrarValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ResellingAgent is PartyIdentification137Choice_ ResellingAgentValue)
        {
            writer.WriteStartElement(null, "RsellngAgt", xmlNamespace );
            ResellingAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PhysicalSecuritiesAgent is PartyIdentification137Choice_ PhysicalSecuritiesAgentValue)
        {
            writer.WriteStartElement(null, "PhysSctiesAgt", xmlNamespace );
            PhysicalSecuritiesAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DropAgent is PartyIdentification137Choice_ DropAgentValue)
        {
            writer.WriteStartElement(null, "DrpAgt", xmlNamespace );
            DropAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SolicitationAgent is PartyIdentification137Choice_ SolicitationAgentValue)
        {
            writer.WriteStartElement(null, "SlctnAgt", xmlNamespace );
            SolicitationAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InformationAgent is PartyIdentification137Choice_ InformationAgentValue)
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
    public static CorporateActionMovementPreliminaryAdviceCancellationAdvice002V12 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CorporateActionMovementPreliminaryAdviceCancellationAdvice002V12"/>.
/// </summary>
[Serializable]
public partial record CorporateActionMovementPreliminaryAdviceCancellationAdvice002V12Document : IOuterDocument<CorporateActionMovementPreliminaryAdviceCancellationAdvice002V12>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.044.002.12";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CorporateActionMovementPreliminaryAdviceCancellationAdvice002V12"/> is required.
    /// </summary>
    [DataMember(Name=CorporateActionMovementPreliminaryAdviceCancellationAdvice002V12.XmlTag)]
    public required CorporateActionMovementPreliminaryAdviceCancellationAdvice002V12 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(CorporateActionMovementPreliminaryAdviceCancellationAdvice002V12.XmlTag);
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
