﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reason.  ISO2002 ID# _6HWbkZNLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.AcceptedStatus10Choice;

/// <summary>
/// Reason for the accepted status.
/// </summary>
public partial record Reason : AcceptedStatus10Choice_
     , IIsoXmlSerilizable<Reason>
{
    #nullable enable
    
    /// <summary>
    /// Specifies the reason why the instruction has been accepted.
    /// </summary>
    public required AcceptedReason12Choice_ ReasonCode { get; init; } 
    /// <summary>
    /// Provides additional information about the processed instruction.
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
    public override void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "RsnCd", xmlNamespace );
        ReasonCode.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (AdditionalReasonInformation is IsoRestrictedFINXMax210Text AdditionalReasonInformationValue)
        {
            writer.WriteStartElement(null, "AddtlRsnInf", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax210Text(AdditionalReasonInformationValue)); // data type RestrictedFINXMax210Text System.String
            writer.WriteEndElement();
        }
    }
    public static new Reason Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
