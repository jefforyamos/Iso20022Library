﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ModificationRequested.  ISO2002 ID# _ddARfDi8Eeydid5dcNPKvg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus90Choice;

/// <summary>
/// Modification request from your counterparty for this transaction is pending waiting for your cancellation request or your consent.
/// </summary>
public partial record ModificationRequested : ProcessingStatus90Choice_
     , IIsoXmlSerilizable<ModificationRequested>
{
    #nullable enable
    
    /// <summary>
    /// Proprietary identification of the reason related to a status.
    /// </summary>
    public GenericIdentification47? Reason { get; init; } 
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
        if (Reason is GenericIdentification47 ReasonValue)
        {
            writer.WriteStartElement(null, "Rsn", xmlNamespace );
            ReasonValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AdditionalReasonInformation is IsoRestrictedFINXMax210Text AdditionalReasonInformationValue)
        {
            writer.WriteStartElement(null, "AddtlRsnInf", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax210Text(AdditionalReasonInformationValue)); // data type RestrictedFINXMax210Text System.String
            writer.WriteEndElement();
        }
    }
    public static new ModificationRequested Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
