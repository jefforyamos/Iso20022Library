﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesSubBalanceTypeAndQuantityBreakdown6.  ISO2002 ID# _cadPUTi8Eeydid5dcNPKvg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Quantity breakdown information for a specific securities balance.
/// </summary>
public partial record SecuritiesSubBalanceTypeAndQuantityBreakdown6
     : IIsoXmlSerilizable<SecuritiesSubBalanceTypeAndQuantityBreakdown6>
{
    #nullable enable
    
    /// <summary>
    /// Specifies the securities sub balance type indicator (example restriction type for a market infrastructure).
    /// </summary>
    public required SecuritiesBalanceType8Choice_ Type { get; init; } 
    /// <summary>
    /// Breakdown of a quantity into lots such as tax lots, instrument series.
    /// </summary>
    public QuantityBreakdown65? QuantityBreakdown { get; init; } 
    
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
        writer.WriteStartElement(null, "Tp", xmlNamespace );
        Type.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (QuantityBreakdown is QuantityBreakdown65 QuantityBreakdownValue)
        {
            writer.WriteStartElement(null, "QtyBrkdwn", xmlNamespace );
            QuantityBreakdownValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static SecuritiesSubBalanceTypeAndQuantityBreakdown6 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
