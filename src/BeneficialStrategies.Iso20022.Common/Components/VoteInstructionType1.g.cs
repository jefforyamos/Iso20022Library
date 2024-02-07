﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for VoteInstructionType1.  ISO2002 ID# _ScucEK4JEemG7MmivSuE5g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Vote options for a resolution.
/// </summary>
public partial record VoteInstructionType1
     : IIsoXmlSerilizable<VoteInstructionType1>
{
    #nullable enable
    
    /// <summary>
    /// Vote option allowed at the resolution level.
    /// </summary>
    public required VoteInstructionType1Choice_ VoteInstructionTypeCode { get; init; } 
    /// <summary>
    /// Additional information about the vote instruction type code when expressed as a proprietary code.
    /// </summary>
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
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
        writer.WriteStartElement(null, "VoteInstrTpCd", xmlNamespace );
        VoteInstructionTypeCode.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (AdditionalInformation is IsoMax350Text AdditionalInformationValue)
        {
            writer.WriteStartElement(null, "AddtlInf", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax350Text(AdditionalInformationValue)); // data type Max350Text System.String
            writer.WriteEndElement();
        }
    }
    public static VoteInstructionType1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
