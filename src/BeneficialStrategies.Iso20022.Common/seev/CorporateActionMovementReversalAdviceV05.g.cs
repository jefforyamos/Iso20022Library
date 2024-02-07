﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CorporateActionMovementReversalAdviceV05.  ISO2002 ID# _2B2d_RbDEeOb5dMswipsLQ.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.seev.CorporateActionMovementReversalAdviceV05>;

namespace BeneficialStrategies.Iso20022.seev;


/// <summary>
/// This record is an implementation of the seev.037.001.05 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope|An account servicer sends the CorporateActionMovementReversalAdvice message to an account owner or its designated agent to reverse previously confirmed posting of securities or cash.|Usage|The message may also be used to:|- re-send a message previously sent (the sub-function of the message is Duplicate),|- provide a third party with a copy of a message for information (the sub-function of the message is Copy),|- re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate),|using the relevant elements in the business application header (BAH).|ISO 15022 - 20022 COEXISTENCE
/// This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”.
/// </summary>
[Serializable]
[Description(@"Scope|An account servicer sends the CorporateActionMovementReversalAdvice message to an account owner or its designated agent to reverse previously confirmed posting of securities or cash.|Usage|The message may also be used to:|- re-send a message previously sent (the sub-function of the message is Duplicate),|- provide a third party with a copy of a message for information (the sub-function of the message is Copy),|- re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate),|using the relevant elements in the business application header (BAH).|ISO 15022 - 20022 COEXISTENCE|This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”.")]
public partial record CorporateActionMovementReversalAdviceV05 : IOuterRecord<CorporateActionMovementReversalAdviceV05,CorporateActionMovementReversalAdviceV05Document>
    ,IIsoXmlSerilizable<CorporateActionMovementReversalAdviceV05>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.037.001.05";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CorpActnMvmntRvslAdvc";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => CorporateActionMovementReversalAdviceV05Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Identification of a previously sent movement confirmation document.
    /// </summary>
    [IsoId("_2B2eERbDEeOb5dMswipsLQ")]
    [Description(@"Identification of a previously sent movement confirmation document.")]
    [DataMember(Name="MvmntConfId")]
    [XmlElement(ElementName="MvmntConfId")]
    [Required]
    public required DocumentIdentification15 MovementConfirmationIdentification { get; init; }
    
    /// <summary>
    /// Identification of other documents as well as the document number.
    /// </summary>
    [IsoId("_2B2eExbDEeOb5dMswipsLQ")]
    [Description(@"Identification of other documents as well as the document number.")]
    [DataMember(Name="OthrDocId")]
    [XmlElement(ElementName="OthrDocId")]
    public DocumentIdentification13? OtherDocumentIdentification { get; init; }
    
    /// <summary>
    /// Identification of an other corporate action event that needs to be closely linked to the processing of the event notified in this document.
    /// </summary>
    [IsoId("_2B2eFRbDEeOb5dMswipsLQ")]
    [Description(@"Identification of an other corporate action event that needs to be closely linked to the processing of the event notified in this document.")]
    [DataMember(Name="EvtsLkg")]
    [XmlElement(ElementName="EvtsLkg")]
    public CorporateActionEventReference1? EventsLinkage { get; init; }
    
    /// <summary>
    /// Reason for the reversal.
    /// </summary>
    [IsoId("_2B2eFxbDEeOb5dMswipsLQ")]
    [Description(@"Reason for the reversal.")]
    [DataMember(Name="RvslRsn")]
    [XmlElement(ElementName="RvslRsn")]
    public CorporateActionReversalReason1? ReversalReason { get; init; }
    
    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_2B2eGRbDEeOb5dMswipsLQ")]
    [Description(@"General information about the corporate action event.")]
    [DataMember(Name="CorpActnGnlInf")]
    [XmlElement(ElementName="CorpActnGnlInf")]
    [Required]
    public required CorporateActionGeneralInformation50 CorporateActionGeneralInformation { get; init; }
    
    /// <summary>
    /// General information about the safekeeping account, owner and account balance.
    /// </summary>
    [IsoId("_2B2eGxbDEeOb5dMswipsLQ")]
    [Description(@"General information about the safekeeping account, owner and account balance.")]
    [DataMember(Name="AcctDtls")]
    [XmlElement(ElementName="AcctDtls")]
    [Required]
    public required AccountAndBalance4 AccountDetails { get; init; }
    
    /// <summary>
    /// Information about the corporate action event.
    /// </summary>
    [IsoId("_nwz-0SUqEeO8eOSw0QN9mA")]
    [Description(@"Information about the corporate action event.")]
    [DataMember(Name="CorpActnDtls")]
    [XmlElement(ElementName="CorpActnDtls")]
    public CorporateAction14? CorporateActionDetails { get; init; }
    
    /// <summary>
    /// Information about the corporate action option.
    /// </summary>
    [IsoId("_2B2eHRbDEeOb5dMswipsLQ")]
    [Description(@"Information about the corporate action option.")]
    [DataMember(Name="CorpActnConfDtls")]
    [XmlElement(ElementName="CorpActnConfDtls")]
    [Required]
    public required CorporateActionOption39 CorporateActionConfirmationDetails { get; init; }
    
    /// <summary>
    /// Provides additional information.
    /// </summary>
    [IsoId("_2B2eHxbDEeOb5dMswipsLQ")]
    [Description(@"Provides additional information.")]
    [DataMember(Name="AddtlInf")]
    [XmlElement(ElementName="AddtlInf")]
    public CorporateActionNarrative4? AdditionalInformation { get; init; }
    
    /// <summary>
    /// Party appointed to administer the event on behalf of the issuer company/offeror. The party may be contacted for more information about the event.
    /// </summary>
    [IsoId("_2B2eIRbDEeOb5dMswipsLQ")]
    [Description(@"Party appointed to administer the event on behalf of the issuer company/offeror. The party may be contacted for more information about the event.")]
    [DataMember(Name="IssrAgt")]
    [XmlElement(ElementName="IssrAgt")]
    public PartyIdentification46Choice_? IssuerAgent { get; init; }
    
    /// <summary>
    /// Agent (principal or fiscal paying agent) appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.
    /// </summary>
    [IsoId("_2B2eIxbDEeOb5dMswipsLQ")]
    [Description(@"Agent (principal or fiscal paying agent) appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.")]
    [DataMember(Name="PngAgt")]
    [XmlElement(ElementName="PngAgt")]
    public PartyIdentification46Choice_? PayingAgent { get; init; }
    
    /// <summary>
    /// Sub-agent appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.
    /// </summary>
    [IsoId("_2B2eJRbDEeOb5dMswipsLQ")]
    [Description(@"Sub-agent appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.")]
    [DataMember(Name="SubPngAgt")]
    [XmlElement(ElementName="SubPngAgt")]
    public PartyIdentification46Choice_? SubPayingAgent { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_2B2eJxbDEeOb5dMswipsLQ")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CorporateActionMovementReversalAdviceV05Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CorporateActionMovementReversalAdviceV05Document ToDocument()
    {
        return new CorporateActionMovementReversalAdviceV05Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("CorpActnMvmntRvslAdvc");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "MvmntConfId", xmlNamespace );
        MovementConfirmationIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (OtherDocumentIdentification is DocumentIdentification13 OtherDocumentIdentificationValue)
        {
            writer.WriteStartElement(null, "OthrDocId", xmlNamespace );
            OtherDocumentIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (EventsLinkage is CorporateActionEventReference1 EventsLinkageValue)
        {
            writer.WriteStartElement(null, "EvtsLkg", xmlNamespace );
            EventsLinkageValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ReversalReason is CorporateActionReversalReason1 ReversalReasonValue)
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
        if (CorporateActionDetails is CorporateAction14 CorporateActionDetailsValue)
        {
            writer.WriteStartElement(null, "CorpActnDtls", xmlNamespace );
            CorporateActionDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "CorpActnConfDtls", xmlNamespace );
        CorporateActionConfirmationDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (AdditionalInformation is CorporateActionNarrative4 AdditionalInformationValue)
        {
            writer.WriteStartElement(null, "AddtlInf", xmlNamespace );
            AdditionalInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (IssuerAgent is PartyIdentification46Choice_ IssuerAgentValue)
        {
            writer.WriteStartElement(null, "IssrAgt", xmlNamespace );
            IssuerAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PayingAgent is PartyIdentification46Choice_ PayingAgentValue)
        {
            writer.WriteStartElement(null, "PngAgt", xmlNamespace );
            PayingAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SubPayingAgent is PartyIdentification46Choice_ SubPayingAgentValue)
        {
            writer.WriteStartElement(null, "SubPngAgt", xmlNamespace );
            SubPayingAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CorporateActionMovementReversalAdviceV05 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CorporateActionMovementReversalAdviceV05"/>.
/// </summary>
[Serializable]
public partial record CorporateActionMovementReversalAdviceV05Document : IOuterDocument<CorporateActionMovementReversalAdviceV05>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.037.001.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CorporateActionMovementReversalAdviceV05"/> is required.
    /// </summary>
    [DataMember(Name=CorporateActionMovementReversalAdviceV05.XmlTag)]
    public required CorporateActionMovementReversalAdviceV05 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(CorporateActionMovementReversalAdviceV05.XmlTag);
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
