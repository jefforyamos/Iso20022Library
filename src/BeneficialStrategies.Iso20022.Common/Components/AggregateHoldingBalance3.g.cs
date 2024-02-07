﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AggregateHoldingBalance3.  ISO2002 ID# _YlFnMVV3Eea1MPROA61PoQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Overall holding position, in a single financial instrument, held in a securities account at a specified place of safekeeping.
/// </summary>
public partial record AggregateHoldingBalance3
     : IIsoXmlSerilizable<AggregateHoldingBalance3>
{
    #nullable enable
    
    /// <summary>
    /// Report on the net position of a financial instrument on the sub-account, for a certain date.
    /// </summary>
    public AggregateHoldingBalance1? BalanceForAccount { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _g8YpUlV3Eea1MPROA61PoQ
    /// <summary>
    /// Agent of the financial instrument, for example, a trade intermediary.
    /// </summary>
    public Intermediary29? Agent { get; init; } 
    
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
        // Not sure how to serialize BalanceForAccount, multiplicity Unknown
        if (Agent is Intermediary29 AgentValue)
        {
            writer.WriteStartElement(null, "Agt", xmlNamespace );
            AgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static AggregateHoldingBalance3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
