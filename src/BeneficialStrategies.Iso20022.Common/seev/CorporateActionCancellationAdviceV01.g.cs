﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CorporateActionCancellationAdviceV01.  ISO2002 ID# _TSqlENEwEd-BzquC8wXy7w_-20074079.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.seev.CorporateActionCancellationAdviceV01>;

namespace BeneficialStrategies.Iso20022.seev;


/// <summary>
/// This record is an implementation of the seev.039.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account servicer sends the CorporateActionCancellationAdvice message to an account owner or its designated agent to cancel a previously announced corporate action event in case of error from the account servicer or in case of withdrawal by the issuer.
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent (the sub-function of the message is Duplicate),
/// - provide a third party with a copy of a message for information (the sub-function of the message is Copy),
/// - re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate).|ISO 15022 - 20022 COEXISTENCE|This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”.
/// </summary>
[Serializable]
[Description(@"Scope|An account servicer sends the CorporateActionCancellationAdvice message to an account owner or its designated agent to cancel a previously announced corporate action event in case of error from the account servicer or in case of withdrawal by the issuer.|Usage|The message may also be used to:|- re-send a message previously sent (the sub-function of the message is Duplicate),|- provide a third party with a copy of a message for information (the sub-function of the message is Copy),|- re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate).|ISO 15022 - 20022 COEXISTENCE|This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”.")]
public partial record CorporateActionCancellationAdviceV01 : IOuterRecord<CorporateActionCancellationAdviceV01,CorporateActionCancellationAdviceV01Document>
    ,IIsoXmlSerilizable<CorporateActionCancellationAdviceV01>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.039.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CorpActnCxlAdvc";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => CorporateActionCancellationAdviceV01Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Information that unambiguously identifies a CorporateActionCancellationAdvice message as know by the account servicer.
    /// </summary>
    [IsoId("_TSqlEdEwEd-BzquC8wXy7w_9989089")]
    [Description(@"Information that unambiguously identifies a CorporateActionCancellationAdvice message as know by the account servicer.")]
    [DataMember(Name="Id")]
    [XmlElement(ElementName="Id")]
    [Required]
    public required DocumentIdentification11 Identification { get; init; }
    
    /// <summary>
    /// General information about the event cancellation status and cancellation reason.
    /// </summary>
    [IsoId("_TS0WANEwEd-BzquC8wXy7w_792870321")]
    [Description(@"General information about the event cancellation status and cancellation reason.")]
    [DataMember(Name="CxlAdvcGnlInf")]
    [XmlElement(ElementName="CxlAdvcGnlInf")]
    [Required]
    public required CorporateActionCancellation1 CancellationAdviceGeneralInformation { get; init; }
    
    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_TS0WAdEwEd-BzquC8wXy7w_-203609952")]
    [Description(@"General information about the corporate action event.")]
    [DataMember(Name="CorpActnGnlInf")]
    [XmlElement(ElementName="CorpActnGnlInf")]
    [Required]
    public required CorporateActionGeneralInformation8 CorporateActionGeneralInformation { get; init; }
    
    /// <summary>
    /// General information about the safekeeping account and the account owner.
    /// </summary>
    [IsoId("_TS0WAtEwEd-BzquC8wXy7w_-277720042")]
    [Description(@"General information about the safekeeping account and the account owner.")]
    [DataMember(Name="AcctsDtls")]
    [XmlElement(ElementName="AcctsDtls")]
    [Required]
    public required AccountIdentification6Choice_ AccountsDetails { get; init; }
    
    /// <summary>
    /// Party that originated the message, if other than the sender.
    /// </summary>
    [IsoId("_TS0WA9EwEd-BzquC8wXy7w_-1882571662")]
    [Description(@"Party that originated the message, if other than the sender.")]
    [DataMember(Name="MsgOrgtr")]
    [XmlElement(ElementName="MsgOrgtr")]
    public PartyIdentification10Choice_? MessageOriginator { get; init; }
    
    /// <summary>
    /// Party that is the final destination of the message, if other than the receiver.
    /// </summary>
    [IsoId("_TS0WBNEwEd-BzquC8wXy7w_-1841935668")]
    [Description(@"Party that is the final destination of the message, if other than the receiver.")]
    [DataMember(Name="MsgRcpt")]
    [XmlElement(ElementName="MsgRcpt")]
    public PartyIdentification10Choice_? MessageRecipient { get; init; }
    
    /// <summary>
    /// Party appointed to administer the event on behalf of the issuer company/offeror. The party may be contacted for more information about the event.
    /// </summary>
    [IsoId("_TS0WBdEwEd-BzquC8wXy7w_-1577810223")]
    [Description(@"Party appointed to administer the event on behalf of the issuer company/offeror. The party may be contacted for more information about the event.")]
    [DataMember(Name="IssrAgt")]
    [XmlElement(ElementName="IssrAgt")]
    public PartyIdentification10Choice_? IssuerAgent { get; init; }
    
    /// <summary>
    /// Agent (principal or fiscal paying agent) appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.
    /// </summary>
    [IsoId("_TS0WBtEwEd-BzquC8wXy7w_-1527937239")]
    [Description(@"Agent (principal or fiscal paying agent) appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.")]
    [DataMember(Name="PngAgt")]
    [XmlElement(ElementName="PngAgt")]
    public PartyIdentification10Choice_? PayingAgent { get; init; }
    
    /// <summary>
    /// Sub-agent appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.
    /// </summary>
    [IsoId("_TS0WB9EwEd-BzquC8wXy7w_-1469758174")]
    [Description(@"Sub-agent appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.")]
    [DataMember(Name="SubPngAgt")]
    [XmlElement(ElementName="SubPngAgt")]
    public PartyIdentification10Choice_? SubPayingAgent { get; init; }
    
    /// <summary>
    /// Party/agent responsible for maintaining the register of a security.
    /// </summary>
    [IsoId("_TS-HANEwEd-BzquC8wXy7w_-1193624355")]
    [Description(@"Party/agent responsible for maintaining the register of a security.")]
    [DataMember(Name="Regar")]
    [XmlElement(ElementName="Regar")]
    public PartyIdentification10Choice_? Registrar { get; init; }
    
    /// <summary>
    /// A broker-dealer responsible for reselling to new investors securities (usually bonds) that have been tendered for purchase by their owner.
    /// </summary>
    [IsoId("_TS-HAdEwEd-BzquC8wXy7w_827404384")]
    [Description(@"A broker-dealer responsible for reselling to new investors securities (usually bonds) that have been tendered for purchase by their owner.")]
    [DataMember(Name="RsellngAgt")]
    [XmlElement(ElementName="RsellngAgt")]
    public PartyIdentification10Choice_? ResellingAgent { get; init; }
    
    /// <summary>
    /// A trust company, bank or similar financial institution assigned by an issuer to accept presentations of instruments, usually bonds, for transfer and or exchange.
    /// </summary>
    [IsoId("_TS-HAtEwEd-BzquC8wXy7w_815399500")]
    [Description(@"A trust company, bank or similar financial institution assigned by an issuer to accept presentations of instruments, usually bonds, for transfer and or exchange.")]
    [DataMember(Name="PhysSctiesAgt")]
    [XmlElement(ElementName="PhysSctiesAgt")]
    public PartyIdentification10Choice_? PhysicalSecuritiesAgent { get; init; }
    
    /// <summary>
    /// A trust company, bank or similar financial institution who acts on behalf of an out of town agent or event agent where securities can be delivered in person.
    /// </summary>
    [IsoId("_TS-HA9EwEd-BzquC8wXy7w_812626549")]
    [Description(@"A trust company, bank or similar financial institution who acts on behalf of an out of town agent or event agent where securities can be delivered in person.")]
    [DataMember(Name="DrpAgt")]
    [XmlElement(ElementName="DrpAgt")]
    public PartyIdentification10Choice_? DropAgent { get; init; }
    
    /// <summary>
    /// A trust company, bank or similar financial institution assigned by an issuer to maintain records of investors and account balances and transactions for the consent of a material change.
    /// </summary>
    [IsoId("_TS-HBNEwEd-BzquC8wXy7w_838487177")]
    [Description(@"A trust company, bank or similar financial institution assigned by an issuer to maintain records of investors and account balances and transactions for the consent of a material change.")]
    [DataMember(Name="SlctnAgt")]
    [XmlElement(ElementName="SlctnAgt")]
    public PartyIdentification10Choice_? SolicitationAgent { get; init; }
    
    /// <summary>
    /// A trust company, bank or similar financial institution assigned by an Issuer to provide information and copies of the offering documentation.
    /// </summary>
    [IsoId("_TS-HBdEwEd-BzquC8wXy7w_842181136")]
    [Description(@"A trust company, bank or similar financial institution assigned by an Issuer to provide information and copies of the offering documentation.")]
    [DataMember(Name="InfAgt")]
    [XmlElement(ElementName="InfAgt")]
    public PartyIdentification10Choice_? InformationAgent { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_TS-HBtEwEd-BzquC8wXy7w_-1922281510")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public Extension2? Extension { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CorporateActionCancellationAdviceV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CorporateActionCancellationAdviceV01Document ToDocument()
    {
        return new CorporateActionCancellationAdviceV01Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("CorpActnCxlAdvc");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "Id", xmlNamespace );
        Identification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "CxlAdvcGnlInf", xmlNamespace );
        CancellationAdviceGeneralInformation.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "CorpActnGnlInf", xmlNamespace );
        CorporateActionGeneralInformation.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "AcctsDtls", xmlNamespace );
        AccountsDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (MessageOriginator is PartyIdentification10Choice_ MessageOriginatorValue)
        {
            writer.WriteStartElement(null, "MsgOrgtr", xmlNamespace );
            MessageOriginatorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (MessageRecipient is PartyIdentification10Choice_ MessageRecipientValue)
        {
            writer.WriteStartElement(null, "MsgRcpt", xmlNamespace );
            MessageRecipientValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (IssuerAgent is PartyIdentification10Choice_ IssuerAgentValue)
        {
            writer.WriteStartElement(null, "IssrAgt", xmlNamespace );
            IssuerAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PayingAgent is PartyIdentification10Choice_ PayingAgentValue)
        {
            writer.WriteStartElement(null, "PngAgt", xmlNamespace );
            PayingAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SubPayingAgent is PartyIdentification10Choice_ SubPayingAgentValue)
        {
            writer.WriteStartElement(null, "SubPngAgt", xmlNamespace );
            SubPayingAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Registrar is PartyIdentification10Choice_ RegistrarValue)
        {
            writer.WriteStartElement(null, "Regar", xmlNamespace );
            RegistrarValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ResellingAgent is PartyIdentification10Choice_ ResellingAgentValue)
        {
            writer.WriteStartElement(null, "RsellngAgt", xmlNamespace );
            ResellingAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PhysicalSecuritiesAgent is PartyIdentification10Choice_ PhysicalSecuritiesAgentValue)
        {
            writer.WriteStartElement(null, "PhysSctiesAgt", xmlNamespace );
            PhysicalSecuritiesAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DropAgent is PartyIdentification10Choice_ DropAgentValue)
        {
            writer.WriteStartElement(null, "DrpAgt", xmlNamespace );
            DropAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SolicitationAgent is PartyIdentification10Choice_ SolicitationAgentValue)
        {
            writer.WriteStartElement(null, "SlctnAgt", xmlNamespace );
            SolicitationAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InformationAgent is PartyIdentification10Choice_ InformationAgentValue)
        {
            writer.WriteStartElement(null, "InfAgt", xmlNamespace );
            InformationAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Extension is Extension2 ExtensionValue)
        {
            writer.WriteStartElement(null, "Xtnsn", xmlNamespace );
            ExtensionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CorporateActionCancellationAdviceV01 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CorporateActionCancellationAdviceV01"/>.
/// </summary>
[Serializable]
public partial record CorporateActionCancellationAdviceV01Document : IOuterDocument<CorporateActionCancellationAdviceV01>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.039.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CorporateActionCancellationAdviceV01"/> is required.
    /// </summary>
    [DataMember(Name=CorporateActionCancellationAdviceV01.XmlTag)]
    public required CorporateActionCancellationAdviceV01 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(CorporateActionCancellationAdviceV01.XmlTag);
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
