﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for DataSetAction.  ISO2002 ID# _hAas8aidEeWHO_l3hf2rlA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.SecuredMarketReport3Choice;

/// <summary>
/// Provides the reason why no transactions are being reported for a money market reporting period.
/// </summary>
public partial record DataSetAction : SecuredMarketReport3Choice_
     , IIsoXmlSerilizable<DataSetAction>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies the type of report activity for a specific reporting period.
    /// </summary>
    public required ReportPeriodActivity1Code Value { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public override void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "DataSetActn", xmlNamespace );
        writer.WriteValue(Value.ToString()); // Enum value
        writer.WriteEndElement();
    }
    public static new DataSetAction Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
