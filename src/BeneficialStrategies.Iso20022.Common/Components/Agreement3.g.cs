﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Agreement3.  ISO2002 ID# _AxQTQNokEeC60axPepSq7g_-153529059.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contractual details related to the agreement between parties.
/// </summary>
public partial record Agreement3
     : IIsoXmlSerilizable<Agreement3>
{
    #nullable enable
    
    /// <summary>
    /// Full name of the base standard agreement, annexes and amendments in place between the principals and applicable to this deal.
    /// </summary>
    public IsoMax350Text? Description { get; init; } 
    /// <summary>
    /// Numeric representation of the day of the month and year.
    /// </summary>
    public IsoISODateTime? Date { get; init; } 
    /// <summary>
    /// Contractual currency forming the basis of a financing agreement and associated transactions. Usually, but not always, the same as the trade currency.
    /// </summary>
    public CurrencyCode? Currency { get; init; } 
    /// <summary>
    /// Type of financing closing.
    /// </summary>
    public ClosingType1Code? ClosingType { get; init; } 
    /// <summary>
    /// Start date of a financing deal that is the date the buyer pays the seller cash and takes control of the collateral.
    /// </summary>
    public IsoISODateTime? StartDate { get; init; } 
    /// <summary>
    /// Identifies type of settlement.
    /// </summary>
    public DeliveryType2Code? DeliveryType { get; init; } 
    /// <summary>
    /// Fraction of the cash consideration that must be collateralized, expressed as a percent. A margin ratio of 02% indicates that the value of the collateral (after deducting for "haircut") must exceed the cash consideration by 2%.
    /// </summary>
    public IsoPercentageRate? MarginRatio { get; init; } 
    
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
        if (Description is IsoMax350Text DescriptionValue)
        {
            writer.WriteStartElement(null, "Desc", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax350Text(DescriptionValue)); // data type Max350Text System.String
            writer.WriteEndElement();
        }
        if (Date is IsoISODateTime DateValue)
        {
            writer.WriteStartElement(null, "Dt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODateTime(DateValue)); // data type ISODateTime System.DateTime
            writer.WriteEndElement();
        }
        if (Currency is CurrencyCode CurrencyValue)
        {
            writer.WriteStartElement(null, "Ccy", xmlNamespace );
            writer.WriteValue(CurrencyValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (ClosingType is ClosingType1Code ClosingTypeValue)
        {
            writer.WriteStartElement(null, "ClsgTp", xmlNamespace );
            writer.WriteValue(ClosingTypeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (StartDate is IsoISODateTime StartDateValue)
        {
            writer.WriteStartElement(null, "StartDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODateTime(StartDateValue)); // data type ISODateTime System.DateTime
            writer.WriteEndElement();
        }
        if (DeliveryType is DeliveryType2Code DeliveryTypeValue)
        {
            writer.WriteStartElement(null, "DlvryTp", xmlNamespace );
            writer.WriteValue(DeliveryTypeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (MarginRatio is IsoPercentageRate MarginRatioValue)
        {
            writer.WriteStartElement(null, "MrgnRatio", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoPercentageRate(MarginRatioValue)); // data type PercentageRate System.Decimal
            writer.WriteEndElement();
        }
    }
    public static Agreement3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
