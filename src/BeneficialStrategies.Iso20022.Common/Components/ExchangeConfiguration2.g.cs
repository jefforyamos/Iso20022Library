﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ExchangeConfiguration2.  ISO2002 ID# _epY-UR3hEeKWfegf-2AeBQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Configuration parameters of data exchanges.
/// </summary>
public partial record ExchangeConfiguration2
     : IIsoXmlSerilizable<ExchangeConfiguration2>
{
    #nullable enable
    
    /// <summary>
    /// Exchange policy between parties.
    /// </summary>
    public ExchangePolicy1Code? ExchangePolicy { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _e1lnQR3hEeKWfegf-2AeBQ
    /// <summary>
    /// Maximum number of transactions without exchange.
    /// </summary>
    public IsoNumber? MaximumNumber { get; init; } 
    /// <summary>
    /// Maximum cumulative amount of the transactions without exchange.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? MaximumAmount { get; init; } 
    /// <summary>
    /// Timing condition for periodic exchanges.
    /// </summary>
    public ProcessTiming2? TimeCondition { get; init; } 
    
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
        // Not sure how to serialize ExchangePolicy, multiplicity Unknown
        if (MaximumNumber is IsoNumber MaximumNumberValue)
        {
            writer.WriteStartElement(null, "MaxNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoNumber(MaximumNumberValue)); // data type Number System.UInt64
            writer.WriteEndElement();
        }
        if (MaximumAmount is IsoImpliedCurrencyAndAmount MaximumAmountValue)
        {
            writer.WriteStartElement(null, "MaxAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoImpliedCurrencyAndAmount(MaximumAmountValue)); // data type ImpliedCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (TimeCondition is ProcessTiming2 TimeConditionValue)
        {
            writer.WriteStartElement(null, "TmCond", xmlNamespace );
            TimeConditionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static ExchangeConfiguration2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
