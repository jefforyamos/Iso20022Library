﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Undertaking1.  ISO2002 ID# _9ziMYXltEeG7BsjMvd1mEw_-2112761130.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Independent undertaking, such as a demand guarantee or standby letter of credit, that provides financial assurance, to be honoured on the presentation of documents that comply with its terms and conditions.
/// </summary>
public partial record Undertaking1
     : IIsoXmlSerilizable<Undertaking1>
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier assigned by the applicant to the undertaking.
    /// </summary>
    public required IsoMax35Text ApplicantReferenceNumber { get; init; } 
    /// <summary>
    /// Brief description of the purpose of the undertaking. Provided as information for the issuer reference.
    /// </summary>
    public required IsoMax350Text Purpose { get; init; } 
    /// <summary>
    /// Undertaking name.
    /// </summary>
    public required UndertakingName1Code Name { get; init; } 
    /// <summary>
    /// Type of undertaking, for example, performance, payment.
    /// </summary>
    public required UndertakingType1Choice_ Type { get; init; } 
    /// <summary>
    /// Party obligated to reimburse the issuer.
    /// </summary>
    public required PartyIdentification43 Obligor { get; init; } 
    /// <summary>
    /// Party to be named in the undertaking as the “applicant” when different from the obligor.
    /// </summary>
    public PartyIdentification43? Applicant { get; init; } 
    /// <summary>
    /// Party that issues the undertaking (or counter-undertaking).
    /// </summary>
    public required PartyIdentification43 Issuer { get; init; } 
    /// <summary>
    /// Ultimate party in whose favour the undertaking is to be issued.
    /// </summary>
    public PartyIdentification43? Beneficiary { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _9zrWU3ltEeG7BsjMvd1mEw_-33006693
    /// <summary>
    /// Party asked to advise the undertaking to the beneficiary or to another advising party.
    /// </summary>
    public PartyIdentification43? AdvisingParty { get; init; } 
    /// <summary>
    /// Additional party asked to advise the undertaking.
    /// </summary>
    public PartyIdentification43? SecondAdvisingParty { get; init; } 
    /// <summary>
    /// Party that adds its confirmation to the undertaking. For further clarification, reference the applicable rules to which the undertaking is subject.
    /// </summary>
    public PartyIdentification43? Confirmer { get; init; } 
    /// <summary>
    /// Indicates whether the advising bank (confirmer) is requested to add its confirmation to the undertaking. The absence of this element indicates that the advising bank (confirmer) is not requested to add its confirmation to the undertaking.
    /// </summary>
    public IsoYesNoIndicator? ConfirmationIndicator { get; init; } 
    /// <summary>
    /// Indicates whether the undertaking is a local or ancillary undertaking to be issued under a counter-undertaking.
    /// </summary>
    public required IsoYesNoIndicator CounterUndertakingIndicator { get; init; } 
    /// <summary>
    /// Details related to the counter undertaking.
    /// </summary>
    public Undertaking2? CounterUndertaking { get; init; } 
    /// <summary>
    /// Details related to the amount of the undertaking.
    /// </summary>
    public required UndertakingAmount1 UndertakingAmount { get; init; } 
    /// <summary>
    /// Details related to the expiry terms of the undertaking.
    /// </summary>
    public required ExpiryDetails2 ExpiryDetails { get; init; } 
    /// <summary>
    /// Party, in addition to the other parties specified in the undertaking, that is also related to the undertaking.
    /// </summary>
    public PartyAndType1? AdditionalParty { get; init; } 
    /// <summary>
    /// Rules and laws governing the undertaking.
    /// </summary>
    public required GovernanceRules1 GovernanceRulesAndLaw { get; init; } 
    /// <summary>
    /// Details of the underlying transaction for which the undertaking is issued.
    /// </summary>
    public UnderlyingTradeTransaction1? UnderlyingTransaction { get; init; } 
    /// <summary>
    /// Presentation details related to the undertaking.
    /// </summary>
    public Presentation4? PresentationDetails { get; init; } 
    /// <summary>
    /// Wording details and text for the undertaking.
    /// </summary>
    public required UndertakingWording1 UndertakingWording { get; init; } 
    /// <summary>
    /// Indicates whether multiple demands are permitted.
    /// </summary>
    public IsoYesNoIndicator? MultipleDemandIndicator { get; init; } 
    /// <summary>
    /// Indicates whether partial demands/drawings are permitted.
    /// </summary>
    public IsoYesNoIndicator? PartialDemandIndicator { get; init; } 
    /// <summary>
    /// Indicates whether the undertaking is transferable.
    /// </summary>
    public IsoYesNoIndicator? TransferIndicator { get; init; } 
    /// <summary>
    /// Indicates whether the applicant/obligor or beneficiary is responsible for payment of the transfer charges.
    /// </summary>
    public ExternalTypeOfParty1Code? TransferChargesPayableBy { get; init; } 
    /// <summary>
    /// Indicates whether the applicant/obligor or beneficiary is responsible for payment of the confirmation charges.
    /// </summary>
    public ExternalTypeOfParty1Code? ConfirmationChargesPayableBy { get; init; } 
    /// <summary>
    /// Details related to a variation in amount that is automatically applied.
    /// </summary>
    public AutomaticVariation1? AutomaticAmountVariation { get; init; } 
    /// <summary>
    /// Details of the communication channel.
    /// </summary>
    public required CommunicationChannel1 DeliveryChannel { get; init; } 
    /// <summary>
    /// Account nominated by the obligor to record the liability amount of the undertaking.
    /// </summary>
    public CashAccount28? ObligorLiabilityAccount { get; init; } 
    /// <summary>
    /// Account nominated by the obligor for the settlement of charges related to the undertaking.
    /// </summary>
    public CashAccount28? ObligorChargeAccount { get; init; } 
    /// <summary>
    /// Account nominated by the obligor for the settlement of the amount claimed under the undertaking.
    /// </summary>
    public CashAccount28? ObligorSettlementAccount { get; init; } 
    /// <summary>
    /// Document or template enclosed in the undertaking directly related to the undertaking to be issued.
    /// </summary>
    public Document9? EnclosedFile { get; init; } 
    /// <summary>
    /// Additional information related to the application for an undertaking.
    /// </summary>
    public SimpleValueList<IsoMax2000Text> AdditionalApplicationInformation { get; init; } = [];
    
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
        writer.WriteStartElement(null, "ApplcntRefNb", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(ApplicantReferenceNumber)); // data type Max35Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Purp", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax350Text(Purpose)); // data type Max350Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Nm", xmlNamespace );
        writer.WriteValue(Name.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Tp", xmlNamespace );
        Type.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Oblgr", xmlNamespace );
        Obligor.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Applicant is PartyIdentification43 ApplicantValue)
        {
            writer.WriteStartElement(null, "Applcnt", xmlNamespace );
            ApplicantValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Issr", xmlNamespace );
        Issuer.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        // Not sure how to serialize Beneficiary, multiplicity Unknown
        if (AdvisingParty is PartyIdentification43 AdvisingPartyValue)
        {
            writer.WriteStartElement(null, "AdvsgPty", xmlNamespace );
            AdvisingPartyValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SecondAdvisingParty is PartyIdentification43 SecondAdvisingPartyValue)
        {
            writer.WriteStartElement(null, "ScndAdvsgPty", xmlNamespace );
            SecondAdvisingPartyValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Confirmer is PartyIdentification43 ConfirmerValue)
        {
            writer.WriteStartElement(null, "Cnfrmr", xmlNamespace );
            ConfirmerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ConfirmationIndicator is IsoYesNoIndicator ConfirmationIndicatorValue)
        {
            writer.WriteStartElement(null, "ConfInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(ConfirmationIndicatorValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "CntrUdrtkgInd", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(CounterUndertakingIndicator)); // data type YesNoIndicator System.String
        writer.WriteEndElement();
        if (CounterUndertaking is Undertaking2 CounterUndertakingValue)
        {
            writer.WriteStartElement(null, "CntrUdrtkg", xmlNamespace );
            CounterUndertakingValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "UdrtkgAmt", xmlNamespace );
        UndertakingAmount.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "XpryDtls", xmlNamespace );
        ExpiryDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (AdditionalParty is PartyAndType1 AdditionalPartyValue)
        {
            writer.WriteStartElement(null, "AddtlPty", xmlNamespace );
            AdditionalPartyValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "GovncRulesAndLaw", xmlNamespace );
        GovernanceRulesAndLaw.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (UnderlyingTransaction is UnderlyingTradeTransaction1 UnderlyingTransactionValue)
        {
            writer.WriteStartElement(null, "UndrlygTx", xmlNamespace );
            UnderlyingTransactionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PresentationDetails is Presentation4 PresentationDetailsValue)
        {
            writer.WriteStartElement(null, "PresntnDtls", xmlNamespace );
            PresentationDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "UdrtkgWrdg", xmlNamespace );
        UndertakingWording.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (MultipleDemandIndicator is IsoYesNoIndicator MultipleDemandIndicatorValue)
        {
            writer.WriteStartElement(null, "MltplDmndInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(MultipleDemandIndicatorValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (PartialDemandIndicator is IsoYesNoIndicator PartialDemandIndicatorValue)
        {
            writer.WriteStartElement(null, "PrtlDmndInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(PartialDemandIndicatorValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (TransferIndicator is IsoYesNoIndicator TransferIndicatorValue)
        {
            writer.WriteStartElement(null, "TrfInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(TransferIndicatorValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (TransferChargesPayableBy is ExternalTypeOfParty1Code TransferChargesPayableByValue)
        {
            writer.WriteStartElement(null, "TrfChrgsPyblBy", xmlNamespace );
            writer.WriteValue(TransferChargesPayableByValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (ConfirmationChargesPayableBy is ExternalTypeOfParty1Code ConfirmationChargesPayableByValue)
        {
            writer.WriteStartElement(null, "ConfChrgsPyblBy", xmlNamespace );
            writer.WriteValue(ConfirmationChargesPayableByValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (AutomaticAmountVariation is AutomaticVariation1 AutomaticAmountVariationValue)
        {
            writer.WriteStartElement(null, "AutomtcAmtVartn", xmlNamespace );
            AutomaticAmountVariationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "DlvryChanl", xmlNamespace );
        DeliveryChannel.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (ObligorLiabilityAccount is CashAccount28 ObligorLiabilityAccountValue)
        {
            writer.WriteStartElement(null, "OblgrLbltyAcct", xmlNamespace );
            ObligorLiabilityAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ObligorChargeAccount is CashAccount28 ObligorChargeAccountValue)
        {
            writer.WriteStartElement(null, "OblgrChrgAcct", xmlNamespace );
            ObligorChargeAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ObligorSettlementAccount is CashAccount28 ObligorSettlementAccountValue)
        {
            writer.WriteStartElement(null, "OblgrSttlmAcct", xmlNamespace );
            ObligorSettlementAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (EnclosedFile is Document9 EnclosedFileValue)
        {
            writer.WriteStartElement(null, "NclsdFile", xmlNamespace );
            EnclosedFileValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "AddtlApplInf", xmlNamespace );
        AdditionalApplicationInformation.Serialize(writer, xmlNamespace, "Max2000Text", SerializationFormatter.IsoMax2000Text );
        writer.WriteEndElement();
    }
    public static Undertaking1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
