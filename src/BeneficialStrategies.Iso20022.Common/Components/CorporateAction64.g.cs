﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateAction64.  ISO2002 ID# _plRgQTi7Eeydid5dcNPKvg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the corporate action event.
/// </summary>
public partial record CorporateAction64
     : IIsoXmlSerilizable<CorporateAction64>
{
    #nullable enable
    
    /// <summary>
    /// Provides information about the dates related to a corporate action event.
    /// </summary>
    public CorporateActionDate66? DateDetails { get; init; } 
    /// <summary>
    /// Stage in the corporate action event life cycle.
    /// </summary>
    public CorporateActionEventStageFormat15Choice_? EventStage { get; init; } 
    /// <summary>
    /// Indicates that the additional business process relates to a claim on the associated corporate action event.
    /// </summary>
    public AdditionalBusinessProcessFormat20Choice_? AdditionalBusinessProcessIndicator { get; init; } 
    /// <summary>
    /// Type of intermediates securities distribution.
    /// </summary>
    public IntermediateSecuritiesDistributionTypeFormat18Choice_? IntermediateSecuritiesDistributionType { get; init; } 
    /// <summary>
    /// Specifies the type of lottery announced.
    /// </summary>
    public LotteryTypeFormat5Choice_? LotteryType { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        if (DateDetails is CorporateActionDate66 DateDetailsValue)
        {
            writer.WriteStartElement(null, "DtDtls", xmlNamespace );
            DateDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (EventStage is CorporateActionEventStageFormat15Choice_ EventStageValue)
        {
            writer.WriteStartElement(null, "EvtStag", xmlNamespace );
            EventStageValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AdditionalBusinessProcessIndicator is AdditionalBusinessProcessFormat20Choice_ AdditionalBusinessProcessIndicatorValue)
        {
            writer.WriteStartElement(null, "AddtlBizPrcInd", xmlNamespace );
            AdditionalBusinessProcessIndicatorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (IntermediateSecuritiesDistributionType is IntermediateSecuritiesDistributionTypeFormat18Choice_ IntermediateSecuritiesDistributionTypeValue)
        {
            writer.WriteStartElement(null, "IntrmdtSctiesDstrbtnTp", xmlNamespace );
            IntermediateSecuritiesDistributionTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (LotteryType is LotteryTypeFormat5Choice_ LotteryTypeValue)
        {
            writer.WriteStartElement(null, "LtryTp", xmlNamespace );
            LotteryTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CorporateAction64 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
