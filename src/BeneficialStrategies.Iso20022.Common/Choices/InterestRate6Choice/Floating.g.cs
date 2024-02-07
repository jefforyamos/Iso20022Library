﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Floating.  ISO2002 ID# _nf6kwyc1EeaCIe3n1Gx9ug.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.InterestRate6Choice;

/// <summary>
/// Provides details about the variable rate.
/// </summary>
public partial record Floating : InterestRate6Choice_
     , IIsoXmlSerilizable<Floating>
{
    #nullable enable
    
    /// <summary>
    /// Identifies the reference index for the debt instrument.
    /// </summary>
    public required BenchmarkCurveName6Choice_ ReferenceRate { get; init; } 
    /// <summary>
    /// Term of the index/benchmark of a floating rate bond. The term shall be expressed in days, weeks, months or years.
    /// </summary>
    public required InterestRateContractTerm2 Term { get; init; } 
    /// <summary>
    /// Number of basis points above (if positive) or below (if negative) the underlying reference rate to calculate the actual interest rate applicable for a given period at issuance of the floating rate instrument.
    /// Usage:
    /// Used to express differences in interest rates, for example, a difference of 0.10% is equivalent to a change of 10 basis points.
    /// </summary>
    public required IsoMax5Number BasisPointSpread { get; init; } 
    
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
        writer.WriteStartElement(null, "RefRate", xmlNamespace );
        ReferenceRate.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Term", xmlNamespace );
        Term.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "BsisPtSprd", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax5Number(BasisPointSpread)); // data type Max5Number System.UInt64
        writer.WriteEndElement();
    }
    public static new Floating Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
