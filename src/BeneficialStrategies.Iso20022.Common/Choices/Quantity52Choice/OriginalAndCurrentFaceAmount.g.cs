﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for OriginalAndCurrentFaceAmount.  ISO2002 ID# _OovFmRuyEeyhRdHRjakS2w.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.Quantity52Choice;

/// <summary>
/// Face amount and amortised value of security.
/// </summary>
public partial record OriginalAndCurrentFaceAmount : Quantity52Choice_
     , IIsoXmlSerilizable<OriginalAndCurrentFaceAmount>
{
    #nullable enable
    
    /// <summary>
    /// Quantity expressed as an amount representing the face amount, that is, the principal of a debt instrument.
    /// </summary>
    public required IsoImpliedCurrencyAndAmount FaceAmount { get; init; } 
    /// <summary>
    /// Quantity expressed as an amount representing the current amortised face amount of a bond, for example, a periodic reduction/increase of a bond's principal amount.
    /// </summary>
    public required IsoImpliedCurrencyAndAmount AmortisedValue { get; init; } 
    
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
        writer.WriteStartElement(null, "FaceAmt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoImpliedCurrencyAndAmount(FaceAmount)); // data type ImpliedCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
        writer.WriteStartElement(null, "AmtsdVal", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoImpliedCurrencyAndAmount(AmortisedValue)); // data type ImpliedCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
    }
    public static new OriginalAndCurrentFaceAmount Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
