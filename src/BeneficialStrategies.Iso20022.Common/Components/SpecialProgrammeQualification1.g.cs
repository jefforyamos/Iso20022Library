﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SpecialProgrammeQualification1.  ISO2002 ID# _NqO3MEU9Eeea-M6VZkEPUw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data to qualify for incentive or other related programmes.
/// </summary>
public partial record SpecialProgrammeQualification1
     : IIsoXmlSerilizable<SpecialProgrammeQualification1>
{
    #nullable enable
    
    /// <summary>
    /// Name of special programme.
    /// </summary>
    public IsoMax35Text? Programme { get; init; } 
    /// <summary>
    /// Name and value associated with a special programme.
    /// </summary>
    public SpecialProgrammeDetails1? Detail { get; init; } 
    
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
        if (Programme is IsoMax35Text ProgrammeValue)
        {
            writer.WriteStartElement(null, "Prgrmm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ProgrammeValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (Detail is SpecialProgrammeDetails1 DetailValue)
        {
            writer.WriteStartElement(null, "Dtl", xmlNamespace );
            DetailValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static SpecialProgrammeQualification1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
