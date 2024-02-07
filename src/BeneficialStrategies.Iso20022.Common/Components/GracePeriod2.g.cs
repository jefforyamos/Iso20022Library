﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for GracePeriod2.  ISO2002 ID# _CPcywZJMEeuuktRxxQZoNQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Grace period applicable to an instalment plan.
/// </summary>
public partial record GracePeriod2
     : IIsoXmlSerilizable<GracePeriod2>
{
    #nullable enable
    
    /// <summary>
    /// Grace period time relative to the grace period unit type. 
    /// </summary>
    public IsoMax3NumericText? Time { get; init; } 
    /// <summary>
    /// Grace period unit type.
    /// </summary>
    public GracePeriodUnitType1Code? UnitType { get; init; } 
    /// <summary>
    /// Grace period other unit type.
    /// </summary>
    public IsoMax35Text? OtherUnitType { get; init; } 
    /// <summary>
    /// Indicates a customer selected grace period
    /// </summary>
    public Isoboolean? CustomerSelectedGracePeriod { get; init; } 
    
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
        if (Time is IsoMax3NumericText TimeValue)
        {
            writer.WriteStartElement(null, "Tm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax3NumericText(TimeValue)); // data type Max3NumericText System.String
            writer.WriteEndElement();
        }
        if (UnitType is GracePeriodUnitType1Code UnitTypeValue)
        {
            writer.WriteStartElement(null, "UnitTp", xmlNamespace );
            writer.WriteValue(UnitTypeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (OtherUnitType is IsoMax35Text OtherUnitTypeValue)
        {
            writer.WriteStartElement(null, "OthrUnitTp", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(OtherUnitTypeValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (CustomerSelectedGracePeriod is Isoboolean CustomerSelectedGracePeriodValue)
        {
            writer.WriteStartElement(null, "CstmrSelctdGracePrd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.Isoboolean(CustomerSelectedGracePeriodValue)); // data type boolean System.String
            writer.WriteEndElement();
        }
    }
    public static GracePeriod2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
