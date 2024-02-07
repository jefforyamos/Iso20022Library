﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InstructionType3.  ISO2002 ID# _RJpGotp-Ed-ak6NoX_4Aeg_-1074370626.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the type of instruction requested by the submitter by means of a code.
/// </summary>
public partial record InstructionType3
     : IIsoXmlSerilizable<InstructionType3>
{
    #nullable enable
    
    /// <summary>
    /// Specifies whether the data set has to be matched or pre-matched.
    /// </summary>
    public required InstructionType3Code Type { get; init; } 
    
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
        writer.WriteStartElement(null, "Tp", xmlNamespace );
        writer.WriteValue(Type.ToString()); // Enum value
        writer.WriteEndElement();
    }
    public static InstructionType3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
