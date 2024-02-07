﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CCPMemberRequirementsReportV01.  ISO2002 ID# _daMXQeUUEem3X-64-NKdqg.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.auth.CCPMemberRequirementsReportV01>;

namespace BeneficialStrategies.Iso20022.auth;


/// <summary>
/// This record is an implementation of the auth.055.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The CCPMemberRequirementsReport message is sent from the central counterparty to the national competent authority. It is used to inform the national competent authority about the collateral requirements that a central counterparty obligates a clearing member post at the central counterparty.
/// </summary>
[Serializable]
[Description(@"The CCPMemberRequirementsReport message is sent from the central counterparty to the national competent authority. It is used to inform the national competent authority about the collateral requirements that a central counterparty obligates a clearing member post at the central counterparty.")]
public partial record CCPMemberRequirementsReportV01 : IOuterRecord<CCPMemberRequirementsReportV01,CCPMemberRequirementsReportV01Document>
    ,IIsoXmlSerilizable<CCPMemberRequirementsReportV01>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.055.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CCPMmbRqrmntsRpt";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => CCPMemberRequirementsReportV01Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Obligations of a clearing member with respect to a central counterparty that are calculated based on intraday positions.
    /// </summary>
    [IsoId("_daMXSeUUEem3X-64-NKdqg")]
    [Description(@"Obligations of a clearing member with respect to a central counterparty that are calculated based on intraday positions.")]
    [DataMember(Name="IntraDayRqrmntAmt")]
    [XmlElement(ElementName="IntraDayRqrmntAmt")]
    [Required]
    public required IntraDayRequirement1 IntraDayRequirementAmount { get; init; }
    
    /// <summary>
    /// Describes an instance of an intraday margin call being made against a margin account.
    /// </summary>
    [IsoId("_daMXS-UUEem3X-64-NKdqg")]
    [Description(@"Describes an instance of an intraday margin call being made against a margin account.")]
    [DataMember(Name="IntraDayMrgnCall")]
    [XmlElement(ElementName="IntraDayMrgnCall")]
    public IntraDayMarginCall1? IntraDayMarginCall { get; init; }
    
    /// <summary>
    /// Obligations of a clearing member with respect to a central counterparty that are calculated based on end of day positions.
    /// </summary>
    [IsoId("_daMXTeUUEem3X-64-NKdqg")]
    [Description(@"Obligations of a clearing member with respect to a central counterparty that are calculated based on end of day positions.")]
    [DataMember(Name="EndOfDayRqrmnt")]
    [XmlElement(ElementName="EndOfDayRqrmnt")]
    [Required]
    public required EndOfDayRequirement2 EndOfDayRequirement { get; init; }
    
    /// <summary>
    /// Requirement for a clearing member to post collateral at a central counterparty with respect to a default fund.
    /// </summary>
    [IsoId("_daMXT-UUEem3X-64-NKdqg")]
    [Description(@"Requirement for a clearing member to post collateral at a central counterparty with respect to a default fund.")]
    [DataMember(Name="DfltFndRqrmnt")]
    [XmlElement(ElementName="DfltFndRqrmnt")]
    [Required]
    public required DefaultFundRequirement1 DefaultFundRequirement { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_daMXUeUUEem3X-64-NKdqg")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CCPMemberRequirementsReportV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CCPMemberRequirementsReportV01Document ToDocument()
    {
        return new CCPMemberRequirementsReportV01Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("CCPMmbRqrmntsRpt");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "IntraDayRqrmntAmt", xmlNamespace );
        IntraDayRequirementAmount.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (IntraDayMarginCall is IntraDayMarginCall1 IntraDayMarginCallValue)
        {
            writer.WriteStartElement(null, "IntraDayMrgnCall", xmlNamespace );
            IntraDayMarginCallValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "EndOfDayRqrmnt", xmlNamespace );
        EndOfDayRequirement.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "DfltFndRqrmnt", xmlNamespace );
        DefaultFundRequirement.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CCPMemberRequirementsReportV01 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CCPMemberRequirementsReportV01"/>.
/// </summary>
[Serializable]
public partial record CCPMemberRequirementsReportV01Document : IOuterDocument<CCPMemberRequirementsReportV01>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.055.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CCPMemberRequirementsReportV01"/> is required.
    /// </summary>
    [DataMember(Name=CCPMemberRequirementsReportV01.XmlTag)]
    public required CCPMemberRequirementsReportV01 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(CCPMemberRequirementsReportV01.XmlTag);
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
