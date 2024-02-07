﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reason.  ISO2002 ID# _mz-NK_41EeClUvPNHKL9Zw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.PendingStatus12Choice;

/// <summary>
/// Specifies the reason of the PendingStatus.
/// </summary>
public partial record Reason : PendingStatus12Choice_
     , IIsoXmlSerilizable<Reason>
{
    #nullable enable
    
    /// <summary>
    /// Specifies the reason why the instruction has a pending status.
    /// </summary>
    public required PendingReason16Choice_ Code { get; init; } 
    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    public IsoMax210Text? AdditionalReasonInformation { get; init; } 
    
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
        writer.WriteStartElement(null, "Cd", xmlNamespace );
        Code.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (AdditionalReasonInformation is IsoMax210Text AdditionalReasonInformationValue)
        {
            writer.WriteStartElement(null, "AddtlRsnInf", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax210Text(AdditionalReasonInformationValue)); // data type Max210Text System.String
            writer.WriteEndElement();
        }
    }
    public static new Reason Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
