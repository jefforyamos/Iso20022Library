﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for StrategyParameters1.  ISO2002 ID# _Q8h3tNp-Ed-ak6NoX_4Aeg_111456312.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Allows the user to specify the algorithm parameters for the algo strategy.
/// </summary>
public partial record StrategyParameters1
     : IIsoXmlSerilizable<StrategyParameters1>
{
    #nullable enable
    
    /// <summary>
    /// Name of parameter.
    /// </summary>
    public IsoMax35Text? Name { get; init; } 
    /// <summary>
    /// Type of the parameter.
    /// </summary>
    public IsoMax35Text? Type { get; init; } 
    /// <summary>
    /// Defines the target strategy of the order, specifies the type of trading or algorithm strategy.
    /// </summary>
    public IsoMax70Text? TargetStrategy { get; init; } 
    
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
        if (Name is IsoMax35Text NameValue)
        {
            writer.WriteStartElement(null, "Nm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(NameValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (Type is IsoMax35Text TypeValue)
        {
            writer.WriteStartElement(null, "Tp", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(TypeValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (TargetStrategy is IsoMax70Text TargetStrategyValue)
        {
            writer.WriteStartElement(null, "TrgtStrtgy", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax70Text(TargetStrategyValue)); // data type Max70Text System.String
            writer.WriteEndElement();
        }
    }
    public static StrategyParameters1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
