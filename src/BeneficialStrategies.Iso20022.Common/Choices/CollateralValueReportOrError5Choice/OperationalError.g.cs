﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for OperationalError.  ISO2002 ID# _-DiXczpvEemk2e6qGBk8IQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.CollateralValueReportOrError5Choice;

/// <summary>
/// Indicates whether an operational error has been issued during the processing of the related request.
/// </summary>
public partial record OperationalError : CollateralValueReportOrError5Choice_
     , IIsoXmlSerilizable<OperationalError>
{
    #nullable enable
    
    /// <summary>
    /// Specification of the error, in coded or proprietary form.
    /// </summary>
    public required ErrorHandling3Choice_ Error { get; init; } 
    /// <summary>
    /// Specification of the error, in free format.
    /// </summary>
    public IsoMax140Text? Description { get; init; } 
    
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
        writer.WriteStartElement(null, "Err", xmlNamespace );
        Error.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Description is IsoMax140Text DescriptionValue)
        {
            writer.WriteStartElement(null, "Desc", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax140Text(DescriptionValue)); // data type Max140Text System.String
            writer.WriteEndElement();
        }
    }
    public static new OperationalError Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
