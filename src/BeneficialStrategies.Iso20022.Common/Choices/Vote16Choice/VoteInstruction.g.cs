﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for VoteInstruction.  ISO2002 ID# _XbSmlfNoEeqRfth943bvEA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.Vote16Choice;

/// <summary>
/// Instruction specifying the instructed quantity of voting rights per resolution. Split votes can be indicated. If only one type of decision is indicated, the number of votes cast must not be adjusted if the position of the voting party increases.
/// </summary>
public partial record VoteInstruction : Vote16Choice_
     , IIsoXmlSerilizable<VoteInstruction>
{
    #nullable enable
    
    /// <summary>
    /// Number of the resolution as specified by the issuer or its agent.
    /// </summary>
    public required IsoMax35Text IssuerLabel { get; init; } 
    /// <summary>
    /// Identifies under the same label a group of agenda resolutions for which a vote in favour can be assigned to only one resolution of that group.
    /// </summary>
    public IsoMax35Text? ListingGroupResolutionLabel { get; init; } 
    /// <summary>
    /// Number of votes in favour of one resolution.
    /// </summary>
    public QuantityOrCode1Choice_? For { get; init; } 
    /// <summary>
    /// Number of votes against one resolution.
    /// </summary>
    public QuantityOrCode1Choice_? Against { get; init; } 
    /// <summary>
    /// Number of abstention votes for one resolution.
    /// </summary>
    public QuantityOrCode1Choice_? Abstain { get; init; } 
    /// <summary>
    /// Number of votes withheld for one resolution.
    /// </summary>
    public QuantityOrCode1Choice_? Withhold { get; init; } 
    /// <summary>
    /// Number of votes in line with the votes of the management.
    /// </summary>
    public QuantityOrCode1Choice_? WithManagement { get; init; } 
    /// <summary>
    /// Number of votes against the voting recommendation of the management.
    /// </summary>
    public QuantityOrCode1Choice_? AgainstManagement { get; init; } 
    /// <summary>
    /// Number of votes for which decision is left to the party that will exercise the voting right.
    /// </summary>
    public QuantityOrCode1Choice_? Discretionary { get; init; } 
    /// <summary>
    /// Number of votes in favour for one year for "say on pay" type of resolution.
    /// </summary>
    public QuantityOrCode1Choice_? OneYear { get; init; } 
    /// <summary>
    /// Number of votes in favour of two years for "say on pay" type of resolution.
    /// </summary>
    public QuantityOrCode1Choice_? TwoYears { get; init; } 
    /// <summary>
    /// Number of votes in favour of three years for "say on pay" type of resolution.
    /// </summary>
    public QuantityOrCode1Choice_? ThreeYears { get; init; } 
    /// <summary>
    /// Do not vote.
    /// </summary>
    public QuantityOrCode1Choice_? NoAction { get; init; } 
    /// <summary>
    /// Vote is cast as empty but the vote is counted.
    /// </summary>
    public QuantityOrCode1Choice_? Blank { get; init; } 
    /// <summary>
    /// Other type of vote expressed as a proprietary code.
    /// </summary>
    public ValueList<ProprietaryVote1> Proprietary { get; init; } = [];
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public override void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "IssrLabl", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(IssuerLabel)); // data type Max35Text System.String
        writer.WriteEndElement();
        if (ListingGroupResolutionLabel is IsoMax35Text ListingGroupResolutionLabelValue)
        {
            writer.WriteStartElement(null, "ListgGrpRsltnLabl", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ListingGroupResolutionLabelValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (For is QuantityOrCode1Choice_ ForValue)
        {
            writer.WriteStartElement(null, "For", xmlNamespace );
            ForValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Against is QuantityOrCode1Choice_ AgainstValue)
        {
            writer.WriteStartElement(null, "Agnst", xmlNamespace );
            AgainstValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Abstain is QuantityOrCode1Choice_ AbstainValue)
        {
            writer.WriteStartElement(null, "Abstn", xmlNamespace );
            AbstainValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Withhold is QuantityOrCode1Choice_ WithholdValue)
        {
            writer.WriteStartElement(null, "Wthhld", xmlNamespace );
            WithholdValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (WithManagement is QuantityOrCode1Choice_ WithManagementValue)
        {
            writer.WriteStartElement(null, "WthMgmt", xmlNamespace );
            WithManagementValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AgainstManagement is QuantityOrCode1Choice_ AgainstManagementValue)
        {
            writer.WriteStartElement(null, "AgnstMgmt", xmlNamespace );
            AgainstManagementValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Discretionary is QuantityOrCode1Choice_ DiscretionaryValue)
        {
            writer.WriteStartElement(null, "Dscrtnry", xmlNamespace );
            DiscretionaryValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OneYear is QuantityOrCode1Choice_ OneYearValue)
        {
            writer.WriteStartElement(null, "OneYr", xmlNamespace );
            OneYearValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TwoYears is QuantityOrCode1Choice_ TwoYearsValue)
        {
            writer.WriteStartElement(null, "TwoYrs", xmlNamespace );
            TwoYearsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ThreeYears is QuantityOrCode1Choice_ ThreeYearsValue)
        {
            writer.WriteStartElement(null, "ThreeYrs", xmlNamespace );
            ThreeYearsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (NoAction is QuantityOrCode1Choice_ NoActionValue)
        {
            writer.WriteStartElement(null, "NoActn", xmlNamespace );
            NoActionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Blank is QuantityOrCode1Choice_ BlankValue)
        {
            writer.WriteStartElement(null, "Blnk", xmlNamespace );
            BlankValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Prtry", xmlNamespace );
        Proprietary.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static new VoteInstruction Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
