﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateAction35.  ISO2002 ID# _cdSQPZKQEeWHWpTQn1FFVg.
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
public partial record CorporateAction35
     : IIsoXmlSerilizable<CorporateAction35>
{
    #nullable enable
    
    /// <summary>
    /// Provides information about the dates related to a corporate action event.
    /// </summary>
    public CorporateActionDate50? DateDetails { get; init; } 
    /// <summary>
    /// Stage in the corporate action event life cycle.
    /// </summary>
    public CorporateActionEventStageFormat15Choice_? EventStage { get; init; } 
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
        if (DateDetails is CorporateActionDate50 DateDetailsValue)
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
        if (LotteryType is LotteryTypeFormat5Choice_ LotteryTypeValue)
        {
            writer.WriteStartElement(null, "LtryTp", xmlNamespace );
            LotteryTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CorporateAction35 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
