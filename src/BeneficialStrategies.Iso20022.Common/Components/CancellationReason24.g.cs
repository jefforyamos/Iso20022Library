﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CancellationReason24.  ISO2002 ID# _65Na_ffUEeiNZp_PtLohLw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the reason an instruction or request is cancelled.
/// </summary>
public partial record CancellationReason24
     : IIsoXmlSerilizable<CancellationReason24>
{
    #nullable enable
    
    /// <summary>
    /// Specifies the reason why the instruction is cancelled.
    /// </summary>
    public required CancellationReason37Choice_ Code { get; init; } 
    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    public IsoRestrictedFINXMax210Text? AdditionalReasonInformation { get; init; } 
    
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
        writer.WriteStartElement(null, "Cd", xmlNamespace );
        Code.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (AdditionalReasonInformation is IsoRestrictedFINXMax210Text AdditionalReasonInformationValue)
        {
            writer.WriteStartElement(null, "AddtlRsnInf", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax210Text(AdditionalReasonInformationValue)); // data type RestrictedFINXMax210Text System.String
            writer.WriteEndElement();
        }
    }
    public static CancellationReason24 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
