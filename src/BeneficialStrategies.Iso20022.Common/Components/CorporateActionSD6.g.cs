﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionSD6.  ISO2002 ID# _1RIYZTL3EeKU9IrkkToqcw_-395277893.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details about the lottery.
/// </summary>
public partial record CorporateActionSD6
     : IIsoXmlSerilizable<CorporateActionSD6>
{
    #nullable enable
    
    /// <summary>
    /// Status of the fields of lottery record.
    /// </summary>
    public required WorkflowStatus1Code LotteryRecordStatus { get; init; } 
    
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
        writer.WriteStartElement(null, "LtryRcrdSts", xmlNamespace );
        writer.WriteValue(LotteryRecordStatus.ToString()); // Enum value
        writer.WriteEndElement();
    }
    public static CorporateActionSD6 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
