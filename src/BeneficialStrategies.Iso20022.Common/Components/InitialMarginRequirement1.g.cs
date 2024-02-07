﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InitialMarginRequirement1.  ISO2002 ID# _BTNckKpwEeamNLogr5TkIQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Liability and assets that arise for a clearing member with respect to a central counterparty.
/// </summary>
public partial record InitialMarginRequirement1
     : IIsoXmlSerilizable<InitialMarginRequirement1>
{
    #nullable enable
    
    /// <summary>
    /// Liability a clearing member has to a central counterparty with respect to potential future exposures.
    /// </summary>
    public InitialMarginExposure1? InitialMarginExposure { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _iLGYQKpzEeamNLogr5TkIQ
    /// <summary>
    /// Total value of any credits offsetable against initial margin requirements at the end of day. For example, net liquidating value of option positions, contingent variation margin, delivery credits.
    /// </summary>
    public required IsoActiveCurrencyAndAmount Credit { get; init; } 
    
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
        // Not sure how to serialize InitialMarginExposure, multiplicity Unknown
        writer.WriteStartElement(null, "Cdt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(Credit)); // data type ActiveCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
    }
    public static InitialMarginRequirement1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
