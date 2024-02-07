﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for BusinessError.  ISO2002 ID# _hjLnYGliEeGaMcKyqKNRfQ_363284102.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesAccountOrBusinessError1Choice;

/// <summary>
/// Business error resulting from a rejection.
/// </summary>
public partial record BusinessError : SecuritiesAccountOrBusinessError1Choice_
     , IIsoXmlSerilizable<BusinessError>
{
    #nullable enable
    
    /// <summary>
    /// Specification of the error, in coded or proprietary form.
    /// </summary>
    public required ErrorHandling1Choice_ Error { get; init; } 
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
    public static new BusinessError Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
