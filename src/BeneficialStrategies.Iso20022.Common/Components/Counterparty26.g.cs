﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Counterparty26.  ISO2002 ID# _7aiv0ZQGEeiILOjNP8ro1w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to counterparty identification.
/// </summary>
public partial record Counterparty26
     : IIsoXmlSerilizable<Counterparty26>
{
    #nullable enable
    
    /// <summary>
    /// Unique code identifying the reporting counterparty of the contract.
    /// </summary>
    public required OrganisationIdentification7Choice_ Identification { get; init; } 
    /// <summary>
    /// Indicates if the reporting counterparty is a central counterparty, a financial, non-financial counterparty or other type of counterparty in accordance with regulation.
    /// </summary>
    public CounterpartyTradeNature5Choice_? Nature { get; init; } 
    /// <summary>
    /// Identifies the trading capacity of the seller.
    /// </summary>
    public TradingCapacity7Code? TradingCapacity { get; init; } 
    /// <summary>
    /// Identifies whether the reporting counterparty is a buyer or a seller.
    /// </summary>
    public OptionParty1Code? CounterpartySide { get; init; } 
    
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
        writer.WriteStartElement(null, "Id", xmlNamespace );
        Identification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Nature is CounterpartyTradeNature5Choice_ NatureValue)
        {
            writer.WriteStartElement(null, "Ntr", xmlNamespace );
            NatureValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TradingCapacity is TradingCapacity7Code TradingCapacityValue)
        {
            writer.WriteStartElement(null, "TradgCpcty", xmlNamespace );
            writer.WriteValue(TradingCapacityValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (CounterpartySide is OptionParty1Code CounterpartySideValue)
        {
            writer.WriteStartElement(null, "CtrPtySd", xmlNamespace );
            writer.WriteValue(CounterpartySideValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
    }
    public static Counterparty26 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
