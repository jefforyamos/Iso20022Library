﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InvestorProfile1.  ISO2002 ID# _WK6_oCDNEeWPMvNwVtiMsA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about actions that may be taken on an account.
/// </summary>
public partial record InvestorProfile1
     : IIsoXmlSerilizable<InvestorProfile1>
{
    #nullable enable
    
    /// <summary>
    /// Type of profile.
    /// </summary>
    public ProfileType1Choice_? Type { get; init; } 
    /// <summary>
    /// Status of the profile.
    /// </summary>
    public InvestorProfileStatus1Choice_? Status { get; init; } 
    /// <summary>
    /// Information about the profile for treasury trading.
    /// </summary>
    public TreasuryProfile1? Treasury { get; init; } 
    /// <summary>
    /// Information about the profile for high frequency trading.
    /// </summary>
    public HighFrequencyTradingProfile1? HighFrequencyTrading { get; init; } 
    /// <summary>
    /// Information about the profile for a market marker.
    /// </summary>
    public MarketMakerProfile1? MarketMaker { get; init; } 
    
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
        if (Type is ProfileType1Choice_ TypeValue)
        {
            writer.WriteStartElement(null, "Tp", xmlNamespace );
            TypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Status is InvestorProfileStatus1Choice_ StatusValue)
        {
            writer.WriteStartElement(null, "Sts", xmlNamespace );
            StatusValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Treasury is TreasuryProfile1 TreasuryValue)
        {
            writer.WriteStartElement(null, "Trsr", xmlNamespace );
            TreasuryValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (HighFrequencyTrading is HighFrequencyTradingProfile1 HighFrequencyTradingValue)
        {
            writer.WriteStartElement(null, "HghFrqcyTradg", xmlNamespace );
            HighFrequencyTradingValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (MarketMaker is MarketMakerProfile1 MarketMakerValue)
        {
            writer.WriteStartElement(null, "MktMakr", xmlNamespace );
            MarketMakerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static InvestorProfile1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
