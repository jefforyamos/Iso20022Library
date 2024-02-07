﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for UnitOfMeasure2.  ISO2002 ID# _OO8ZwZF_EeukDPgU2BMkjQ.
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
public partial record UnitOfMeasure2
     : IIsoXmlSerilizable<UnitOfMeasure2>
{
    #nullable enable
    
    /// <summary>
    /// Unit of measure of the item being shipped.
    /// </summary>
    public UnitOfMeasure1Code? UnitOfMeasure { get; init; } 
    /// <summary>
    /// Other unit of measure.
    /// </summary>
    public IsoMax35Text? OtherUnitOfMeasure { get; init; } 
    /// <summary>
    /// Number of units.
    /// </summary>
    public IsoDecimalNumber? NumberOfUnits { get; init; } 
    
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
        if (UnitOfMeasure is UnitOfMeasure1Code UnitOfMeasureValue)
        {
            writer.WriteStartElement(null, "UnitOfMeasr", xmlNamespace );
            writer.WriteValue(UnitOfMeasureValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (OtherUnitOfMeasure is IsoMax35Text OtherUnitOfMeasureValue)
        {
            writer.WriteStartElement(null, "OthrUnitOfMeasr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(OtherUnitOfMeasureValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (NumberOfUnits is IsoDecimalNumber NumberOfUnitsValue)
        {
            writer.WriteStartElement(null, "NbOfUnits", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoDecimalNumber(NumberOfUnitsValue)); // data type DecimalNumber System.UInt64
            writer.WriteEndElement();
        }
    }
    public static UnitOfMeasure2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
