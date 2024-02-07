﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for UnitPrice9.  ISO2002 ID# _Qfn5Qtp-Ed-ak6NoX_4Aeg_-214178771.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money for which goods or services are offered, sold, or bought.
/// </summary>
public partial record UnitPrice9
     : IIsoXmlSerilizable<UnitPrice9>
{
    #nullable enable
    
    /// <summary>
    /// Specifies the unit of measurement. For example, kilo, tons.
    /// </summary>
    public required UnitOfMeasure4Code UnitOfMeasureCode { get; init; } 
    /// <summary>
    /// Identifies the unit of measure not present in the code list.
    /// </summary>
    public required IsoMax35Text OtherUnitOfMeasure { get; init; } 
    /// <summary>
    /// Price expressed as a currency and value.
    /// </summary>
    public required IsoCurrencyAndAmount Amount { get; init; } 
    /// <summary>
    /// Multiplication factor of measurement values. For example: goods that can be ordered by 36 pieces.
    /// </summary>
    public IsoMax15NumericText? Factor { get; init; } 
    
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
        writer.WriteStartElement(null, "UnitOfMeasrCd", xmlNamespace );
        writer.WriteValue(UnitOfMeasureCode.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "OthrUnitOfMeasr", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(OtherUnitOfMeasure)); // data type Max35Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Amt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoCurrencyAndAmount(Amount)); // data type CurrencyAndAmount System.Decimal
        writer.WriteEndElement();
        if (Factor is IsoMax15NumericText FactorValue)
        {
            writer.WriteStartElement(null, "Fctr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax15NumericText(FactorValue)); // data type Max15NumericText System.String
            writer.WriteEndElement();
        }
    }
    public static UnitPrice9 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
