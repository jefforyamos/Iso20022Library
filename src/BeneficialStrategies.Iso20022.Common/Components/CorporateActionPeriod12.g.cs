﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionPeriod12.  ISO2002 ID# _jKREwbQYEeeKRKrD60ELBQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies periods related to a corporate action option.
/// </summary>
public partial record CorporateActionPeriod12
     : IIsoXmlSerilizable<CorporateActionPeriod12>
{
    #nullable enable
    
    /// <summary>
    /// Period during which the price of a security is determined.
    /// </summary>
    public Period6Choice_? PriceCalculationPeriod { get; init; } 
    /// <summary>
    /// Period during which both old and new equity may be traded simultaneously, for example, consolidation of equity or splitting of equity.
    /// </summary>
    public Period6Choice_? ParallelTradingPeriod { get; init; } 
    /// <summary>
    /// Period during which the specified option, or all options of the event, remains valid, for example, offer period.
    /// </summary>
    public Period6Choice_? ActionPeriod { get; init; } 
    /// <summary>
    /// Period during which the shareholder can revoke, change or withdraw its instruction.
    /// </summary>
    public Period6Choice_? RevocabilityPeriod { get; init; } 
    /// <summary>
    /// Period during which the privilege is not available, for example, this can happen whenever a meeting takes place or whenever a coupon payment is due.
    /// </summary>
    public Period6Choice_? PrivilegeSuspensionPeriod { get; init; } 
    /// <summary>
    /// Period during which the participant of the account servicer can revoke change or withdraw its instructions.
    /// </summary>
    public Period6Choice_? AccountServicerRevocabilityPeriod { get; init; } 
    /// <summary>
    /// Period defining the last date on which withdrawal in street name requests on the outturn security will be accepted and the date on which the suspension will be released and withdrawal by transfer processing on the outturn security will resume.
    /// </summary>
    public Period6Choice_? DepositorySuspensionPeriodForWithdrawal { get; init; } 
    
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
        if (PriceCalculationPeriod is Period6Choice_ PriceCalculationPeriodValue)
        {
            writer.WriteStartElement(null, "PricClctnPrd", xmlNamespace );
            PriceCalculationPeriodValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ParallelTradingPeriod is Period6Choice_ ParallelTradingPeriodValue)
        {
            writer.WriteStartElement(null, "ParllTradgPrd", xmlNamespace );
            ParallelTradingPeriodValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ActionPeriod is Period6Choice_ ActionPeriodValue)
        {
            writer.WriteStartElement(null, "ActnPrd", xmlNamespace );
            ActionPeriodValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RevocabilityPeriod is Period6Choice_ RevocabilityPeriodValue)
        {
            writer.WriteStartElement(null, "RvcbltyPrd", xmlNamespace );
            RevocabilityPeriodValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PrivilegeSuspensionPeriod is Period6Choice_ PrivilegeSuspensionPeriodValue)
        {
            writer.WriteStartElement(null, "PrvlgSspnsnPrd", xmlNamespace );
            PrivilegeSuspensionPeriodValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AccountServicerRevocabilityPeriod is Period6Choice_ AccountServicerRevocabilityPeriodValue)
        {
            writer.WriteStartElement(null, "AcctSvcrRvcbltyPrd", xmlNamespace );
            AccountServicerRevocabilityPeriodValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DepositorySuspensionPeriodForWithdrawal is Period6Choice_ DepositorySuspensionPeriodForWithdrawalValue)
        {
            writer.WriteStartElement(null, "DpstrySspnsnPrdForWdrwl", xmlNamespace );
            DepositorySuspensionPeriodForWithdrawalValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CorporateActionPeriod12 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
