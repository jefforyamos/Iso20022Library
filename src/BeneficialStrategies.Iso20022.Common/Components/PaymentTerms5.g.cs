﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentTerms5.  ISO2002 ID# _ZXBQcRVgEeOrY9qSHVspCA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the payment terms of the underlying transaction.
/// </summary>
public partial record PaymentTerms5
     : IIsoXmlSerilizable<PaymentTerms5>
{
    #nullable enable
    
    /// <summary>
    /// Specifies the payment terms using a code or other means.
    /// </summary>
    public required PaymentCodeOrOther2Choice_ PaymentTerms { get; init; } 
    /// <summary>
    /// Specifies if it is a fixed amount or a percentage.
    /// </summary>
    public required AmountOrPercentage2Choice_ AmountOrPercentage { get; init; } 
    
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
        writer.WriteStartElement(null, "PmtTerms", xmlNamespace );
        PaymentTerms.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "AmtOrPctg", xmlNamespace );
        AmountOrPercentage.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static PaymentTerms5 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
