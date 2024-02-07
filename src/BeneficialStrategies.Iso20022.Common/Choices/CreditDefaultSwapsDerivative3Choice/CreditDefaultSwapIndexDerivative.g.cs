﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CreditDefaultSwapIndexDerivative.  ISO2002 ID# _xfbL135eEea2k7EBUopqxw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.CreditDefaultSwapsDerivative3Choice;

/// <summary>
/// A credit default swap derivative on an index.
/// </summary>
public partial record CreditDefaultSwapIndexDerivative : CreditDefaultSwapsDerivative3Choice_
     , IIsoXmlSerilizable<CreditDefaultSwapIndexDerivative>
{
    #nullable enable
    
    /// <summary>
    /// Derivative on a credit default swap with the ISIN code of the underlying index.
    /// </summary>
    public IsoISINOct2015Identifier? UnderlyingIndexIdentification { get; init; } 
    /// <summary>
    /// To be populated for derivatives on a CDS index with the standardized name of the index.
    /// </summary>
    public required IsoMax25Text IndexName { get; init; } 
    /// <summary>
    /// Describes the Index specific details the derivative is being made on.
    /// </summary>
    public required CreditDefaultSwapIndex2 Index { get; init; } 
    
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
        if (UnderlyingIndexIdentification is IsoISINOct2015Identifier UnderlyingIndexIdentificationValue)
        {
            writer.WriteStartElement(null, "UndrlygIndxId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISINOct2015Identifier(UnderlyingIndexIdentificationValue)); // data type ISINOct2015Identifier System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "IndxNm", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax25Text(IndexName)); // data type Max25Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Indx", xmlNamespace );
        Index.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static new CreditDefaultSwapIndexDerivative Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
