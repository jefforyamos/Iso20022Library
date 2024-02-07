﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TaxAmountAndType1.  ISO2002 ID# _ts1L0VkyEeGeoaLUQk__nA_404730048.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the amount with a specific type.
/// </summary>
public partial record TaxAmountAndType1
     : IIsoXmlSerilizable<TaxAmountAndType1>
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of the amount.
    /// </summary>
    public TaxAmountType1Choice_? Type { get; init; } 
    /// <summary>
    /// Amount of money, which has been typed.
    /// </summary>
    public required IsoActiveOrHistoricCurrencyAndAmount Amount { get; init; } 
    
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
        if (Type is TaxAmountType1Choice_ TypeValue)
        {
            writer.WriteStartElement(null, "Tp", xmlNamespace );
            TypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Amt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveOrHistoricCurrencyAndAmount(Amount)); // data type ActiveOrHistoricCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
    }
    public static TaxAmountAndType1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
