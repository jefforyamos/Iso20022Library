﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AgentCAInformationAdviceV01.  ISO2002 ID# _TODKy9EwEd-BzquC8wXy7w_-190409931.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.seev.AgentCAInformationAdviceV01>;

namespace BeneficialStrategies.Iso20022.seev;


/// <summary>
/// This record is an implementation of the seev.023.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// This message is sent by a CSD to an issuer (or its agent) to provide information about the certification and/or the delivery details to the issuer (or its agent).
/// Usage
/// This message can be used in the case of a corporate action event without an election.
/// This message can also be used in the case of a corporate action event with election when the election details and the additional information cannot be provided in the same message. In this case, the Agent Corporate Action Election Advice Identification must be used to link this message to the election advice for which additional information is provided.
/// </summary>
[Serializable]
[Description(@"Scope|This message is sent by a CSD to an issuer (or its agent) to provide information about the certification and/or the delivery details to the issuer (or its agent).|Usage|This message can be used in the case of a corporate action event without an election.|This message can also be used in the case of a corporate action event with election when the election details and the additional information cannot be provided in the same message. In this case, the Agent Corporate Action Election Advice Identification must be used to link this message to the election advice for which additional information is provided.")]
public partial record AgentCAInformationAdviceV01 : IOuterRecord<AgentCAInformationAdviceV01,AgentCAInformationAdviceV01Document>
    ,IIsoXmlSerilizable<AgentCAInformationAdviceV01>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.023.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AgtCAInfAdvc";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => AgentCAInformationAdviceV01Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Identification assigned by the Sender to unambiguously identify the advice.
    /// </summary>
    [IsoId("_TODKzNEwEd-BzquC8wXy7w_1736726928")]
    [Description(@"Identification assigned by the Sender to unambiguously identify the advice.")]
    [DataMember(Name="Id")]
    [XmlElement(ElementName="Id")]
    [Required]
    public required DocumentIdentification8 Identification { get; init; }
    
    /// <summary>
    /// Identification of the linked Agent CA Election Advice Identification.
    /// </summary>
    [IsoId("_TODKzdEwEd-BzquC8wXy7w_1770899654")]
    [Description(@"Identification of the linked Agent CA Election Advice Identification.")]
    [DataMember(Name="AgtCAElctnAdvcId")]
    [XmlElement(ElementName="AgtCAElctnAdvcId")]
    public DocumentIdentification8? AgentCAElectionAdviceIdentification { get; init; }
    
    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_TODKztEwEd-BzquC8wXy7w_582576991")]
    [Description(@"General information about the corporate action event.")]
    [DataMember(Name="CorpActnGnlInf")]
    [XmlElement(ElementName="CorpActnGnlInf")]
    [Required]
    public required CorporateActionInformation1 CorporateActionGeneralInformation { get; init; }
    
    /// <summary>
    /// Information about the account for which additional information is provided.
    /// </summary>
    [IsoId("_TODKz9EwEd-BzquC8wXy7w_-559361420")]
    [Description(@"Information about the account for which additional information is provided.")]
    [DataMember(Name="AcctDtls")]
    [XmlElement(ElementName="AcctDtls")]
    [Required]
    public required SecuritiesAccount7 AccountDetails { get; init; }
    
    /// <summary>
    /// Additional information about the corporate action such as the delivery details.
    /// </summary>
    [IsoId("_TOM7wNEwEd-BzquC8wXy7w_196544282")]
    [Description(@"Additional information about the corporate action such as the delivery details.")]
    [DataMember(Name="CorpActnAddtlInf")]
    [XmlElement(ElementName="CorpActnAddtlInf")]
    [Required]
    public required CorporateActionAdditionalInformation1 CorporateActionAdditionalInformation { get; init; }
    
    /// <summary>
    /// Contact responsible for the transaction identified in the message.
    /// </summary>
    [IsoId("_TOM7wdEwEd-BzquC8wXy7w_485761108")]
    [Description(@"Contact responsible for the transaction identified in the message.")]
    [DataMember(Name="CtctDtls")]
    [XmlElement(ElementName="CtctDtls")]
    public ContactPerson1? ContactDetails { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AgentCAInformationAdviceV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AgentCAInformationAdviceV01Document ToDocument()
    {
        return new AgentCAInformationAdviceV01Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("AgtCAInfAdvc");
    
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
        if (AgentCAElectionAdviceIdentification is DocumentIdentification8 AgentCAElectionAdviceIdentificationValue)
        {
            writer.WriteStartElement(null, "AgtCAElctnAdvcId", xmlNamespace );
            AgentCAElectionAdviceIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "CorpActnGnlInf", xmlNamespace );
        CorporateActionGeneralInformation.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "AcctDtls", xmlNamespace );
        AccountDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "CorpActnAddtlInf", xmlNamespace );
        CorporateActionAdditionalInformation.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (ContactDetails is ContactPerson1 ContactDetailsValue)
        {
            writer.WriteStartElement(null, "CtctDtls", xmlNamespace );
            ContactDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static AgentCAInformationAdviceV01 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AgentCAInformationAdviceV01"/>.
/// </summary>
[Serializable]
public partial record AgentCAInformationAdviceV01Document : IOuterDocument<AgentCAInformationAdviceV01>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.023.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AgentCAInformationAdviceV01"/> is required.
    /// </summary>
    [DataMember(Name=AgentCAInformationAdviceV01.XmlTag)]
    public required AgentCAInformationAdviceV01 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(AgentCAInformationAdviceV01.XmlTag);
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
