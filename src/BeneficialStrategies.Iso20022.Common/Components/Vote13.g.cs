﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Vote13.  ISO2002 ID# _d3vDAbqPEemCAOifqHrKJw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Vote expressed for one resolution.
/// </summary>
public partial record Vote13
     : IIsoXmlSerilizable<Vote13>
{
    #nullable enable
    
    /// <summary>
    /// Number of the resolution as specified by the issuer or its agent.
    /// </summary>
    public required IsoMax35Text IssuerLabel { get; init; } 
    /// <summary>
    /// Number of votes in favour of one resolution.
    /// </summary>
    public FinancialInstrumentQuantity18Choice_? For { get; init; } 
    /// <summary>
    /// Number of votes against one resolution.
    /// </summary>
    public FinancialInstrumentQuantity18Choice_? Against { get; init; } 
    /// <summary>
    /// Number of votes expressed as abstain for one resolution.
    /// </summary>
    public FinancialInstrumentQuantity18Choice_? Abstain { get; init; } 
    /// <summary>
    /// Number of votes withheld for one resolution.
    /// </summary>
    public FinancialInstrumentQuantity18Choice_? Withhold { get; init; } 
    /// <summary>
    /// Number of votes in line with the votes of the management.
    /// </summary>
    public FinancialInstrumentQuantity18Choice_? WithManagement { get; init; } 
    /// <summary>
    /// Number of votes against the voting recommendation of the management.
    /// </summary>
    public FinancialInstrumentQuantity18Choice_? AgainstManagement { get; init; } 
    /// <summary>
    /// Number of votes for which decision is left to the party that will exercise the voting right.
    /// </summary>
    public FinancialInstrumentQuantity18Choice_? Discretionary { get; init; } 
    /// <summary>
    /// Number of votes in favour for one year for "say on pay" type of resolution.
    /// </summary>
    public FinancialInstrumentQuantity18Choice_? OneYear { get; init; } 
    /// <summary>
    /// Number of votes in favour of two years for "say on pay" type of resolution.
    /// </summary>
    public FinancialInstrumentQuantity18Choice_? TwoYears { get; init; } 
    /// <summary>
    /// Number of votes in favour of three years for "say on pay" type of resolution.
    /// </summary>
    public FinancialInstrumentQuantity18Choice_? ThreeYears { get; init; } 
    /// <summary>
    /// Number of votes for which no action has been taken.
    /// </summary>
    public FinancialInstrumentQuantity18Choice_? NoAction { get; init; } 
    /// <summary>
    /// Vote is cast as empty but the vote is counted.
    /// </summary>
    public FinancialInstrumentQuantity18Choice_? Blank { get; init; } 
    /// <summary>
    /// Other type of vote expressed as a proprietary code.
    /// </summary>
    public ValueList<ProprietaryVote2> Proprietary { get; init; } = [];
    /// <summary>
    /// Indicates the resolution was withdrawn at the meeting.
    /// </summary>
    public IsoYesNoIndicator? Withdrawn { get; init; } 
    
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
        writer.WriteStartElement(null, "IssrLabl", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(IssuerLabel)); // data type Max35Text System.String
        writer.WriteEndElement();
        if (For is FinancialInstrumentQuantity18Choice_ ForValue)
        {
            writer.WriteStartElement(null, "For", xmlNamespace );
            ForValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Against is FinancialInstrumentQuantity18Choice_ AgainstValue)
        {
            writer.WriteStartElement(null, "Agnst", xmlNamespace );
            AgainstValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Abstain is FinancialInstrumentQuantity18Choice_ AbstainValue)
        {
            writer.WriteStartElement(null, "Abstn", xmlNamespace );
            AbstainValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Withhold is FinancialInstrumentQuantity18Choice_ WithholdValue)
        {
            writer.WriteStartElement(null, "Wthhld", xmlNamespace );
            WithholdValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (WithManagement is FinancialInstrumentQuantity18Choice_ WithManagementValue)
        {
            writer.WriteStartElement(null, "WthMgmt", xmlNamespace );
            WithManagementValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AgainstManagement is FinancialInstrumentQuantity18Choice_ AgainstManagementValue)
        {
            writer.WriteStartElement(null, "AgnstMgmt", xmlNamespace );
            AgainstManagementValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Discretionary is FinancialInstrumentQuantity18Choice_ DiscretionaryValue)
        {
            writer.WriteStartElement(null, "Dscrtnry", xmlNamespace );
            DiscretionaryValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OneYear is FinancialInstrumentQuantity18Choice_ OneYearValue)
        {
            writer.WriteStartElement(null, "OneYr", xmlNamespace );
            OneYearValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TwoYears is FinancialInstrumentQuantity18Choice_ TwoYearsValue)
        {
            writer.WriteStartElement(null, "TwoYrs", xmlNamespace );
            TwoYearsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ThreeYears is FinancialInstrumentQuantity18Choice_ ThreeYearsValue)
        {
            writer.WriteStartElement(null, "ThreeYrs", xmlNamespace );
            ThreeYearsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (NoAction is FinancialInstrumentQuantity18Choice_ NoActionValue)
        {
            writer.WriteStartElement(null, "NoActn", xmlNamespace );
            NoActionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Blank is FinancialInstrumentQuantity18Choice_ BlankValue)
        {
            writer.WriteStartElement(null, "Blnk", xmlNamespace );
            BlankValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Prtry", xmlNamespace );
        Proprietary.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Withdrawn is IsoYesNoIndicator WithdrawnValue)
        {
            writer.WriteStartElement(null, "Wdrwn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(WithdrawnValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
    }
    public static Vote13 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
