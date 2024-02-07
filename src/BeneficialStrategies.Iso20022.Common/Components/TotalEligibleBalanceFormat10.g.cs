﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TotalEligibleBalanceFormat10.  ISO2002 ID# _KUd0HRuyEeyhRdHRjakS2w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Total eligible balance for the corporate action and full and part way period units.
/// </summary>
public partial record TotalEligibleBalanceFormat10
     : IIsoXmlSerilizable<TotalEligibleBalanceFormat10>
{
    #nullable enable
    
    /// <summary>
    /// Provides information about balance related to a corporate action.
    /// </summary>
    public Quantity49Choice_? Balance { get; init; } 
    /// <summary>
    /// Number of units of a fund that were purchased in a previous distribution period and/or held at the beginning of a distribution period, for example Group I Units in the UK.
    /// </summary>
    public SignedQuantityFormat10? FullPeriodUnits { get; init; } 
    /// <summary>
    /// Number of units of a fund that were purchased part way throughout a distribution period, for example Group II Units in the U.K.
    /// </summary>
    public SignedQuantityFormat10? PartWayPeriodUnits { get; init; } 
    
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
        if (Balance is Quantity49Choice_ BalanceValue)
        {
            writer.WriteStartElement(null, "Bal", xmlNamespace );
            BalanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (FullPeriodUnits is SignedQuantityFormat10 FullPeriodUnitsValue)
        {
            writer.WriteStartElement(null, "FullPrdUnits", xmlNamespace );
            FullPeriodUnitsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PartWayPeriodUnits is SignedQuantityFormat10 PartWayPeriodUnitsValue)
        {
            writer.WriteStartElement(null, "PartWayPrdUnits", xmlNamespace );
            PartWayPeriodUnitsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static TotalEligibleBalanceFormat10 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
