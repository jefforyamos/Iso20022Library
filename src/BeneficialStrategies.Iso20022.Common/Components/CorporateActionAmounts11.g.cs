﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionAmounts11.  ISO2002 ID# _3rpUgfPzEd-ezLm12ErWqA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies amounts in the framework of a corporate action event.
/// </summary>
public partial record CorporateActionAmounts11
     : IIsoXmlSerilizable<CorporateActionAmounts11>
{
    #nullable enable
    
    /// <summary>
    /// Amount of money that is to be/was posted to the account.
    /// </summary>
    public required IsoActiveCurrencyAndAmount PostingAmount { get; init; } 
    /// <summary>
    /// Amount of money before any deductions and allowances have been made.
    /// </summary>
    public IsoActiveCurrencyAndAmount? GrossCashAmount { get; init; } 
    /// <summary>
    /// Amount of money after deductions and allowances have been made, if any, that is, the total amount +/- charges/fees.
    /// </summary>
    public IsoActiveCurrencyAndAmount? NetCashAmount { get; init; } 
    /// <summary>
    /// Amount of cash premium made available in order to encourage participation in the offer. Payment is made to a third party who has solicited an entity to take part in the offer.
    /// </summary>
    public IsoActiveCurrencyAndAmount? SolicitationFees { get; init; } 
    /// <summary>
    /// Cash disbursement in lieu of a fractional quantity of, for example, equity.
    /// </summary>
    public IsoActiveCurrencyAndAmount? CashInLieuOfShare { get; init; } 
    /// <summary>
    /// Amount of money distributed as the result of a capital gain.
    /// </summary>
    public IsoActiveCurrencyAndAmount? CapitalGain { get; init; } 
    /// <summary>
    /// Amount of money representing a coupon payment.
    /// </summary>
    public IsoActiveCurrencyAndAmount? InterestAmount { get; init; } 
    /// <summary>
    /// Amount of money resulting from a market claim.
    /// </summary>
    public IsoActiveCurrencyAndAmount? MarketClaimAmount { get; init; } 
    /// <summary>
    /// (Unique to France) Amount due to a buyer of securities dealt prior to ex date which may be subject to different rate of taxation.
    /// </summary>
    public IsoActiveCurrencyAndAmount? IndemnityAmount { get; init; } 
    /// <summary>
    /// Amount of money that the borrower pays to the lender as a compensation. It does not entitle the lender to reclaim any tax credit and is sometimes treated differently by the local tax authorities of the lender. Also covers compensation/indemnity of missed dividend concerning early/late settlements if applicable to a market.
    /// </summary>
    public IsoActiveCurrencyAndAmount? ManufacturedDividendPaymentAmount { get; init; } 
    /// <summary>
    /// Amount of money reinvested in additional securities.
    /// </summary>
    public IsoActiveCurrencyAndAmount? ReinvestmentAmount { get; init; } 
    /// <summary>
    /// Amount resulting from a fully franked dividend paid by a company; amount includes tax credit for companies that have made sufficient tax payments during the fiscal period.
    /// </summary>
    public IsoActiveCurrencyAndAmount? FullyFrankedAmount { get; init; } 
    /// <summary>
    /// Amount resulting from an unfranked dividend paid by a company; the amount does not include tax credit and is subject to withholding tax.
    /// </summary>
    public IsoActiveCurrencyAndAmount? UnfrankedAmount { get; init; } 
    /// <summary>
    /// Amount of money related to taxable income that cannot be categorised.
    /// </summary>
    public IsoActiveCurrencyAndAmount? SundryOrOtherAmount { get; init; } 
    /// <summary>
    /// Cash premium made available if the securities holder consents or participates to an event, for example, consent fees or solicitation fees.
    /// </summary>
    public IsoActiveCurrencyAndAmount? CashIncentive { get; init; } 
    /// <summary>
    /// Amount of money that has not been subject to taxation.
    /// </summary>
    public IsoActiveCurrencyAndAmount? TaxFreeAmount { get; init; } 
    /// <summary>
    /// Amount of income eligible for deferred taxation.
    /// </summary>
    public IsoActiveCurrencyAndAmount? TaxDeferredAmount { get; init; } 
    /// <summary>
    /// Tax on value added.
    /// </summary>
    public IsoActiveCurrencyAndAmount? ValueAddedTaxAmount { get; init; } 
    /// <summary>
    /// Amount of stamp duty.
    /// </summary>
    public IsoActiveCurrencyAndAmount? StampDutyAmount { get; init; } 
    /// <summary>
    /// Amount that was paid in excess of actual tax obligation and was reclaimed.
    /// </summary>
    public IsoActiveCurrencyAndAmount? TaxReclaimAmount { get; init; } 
    /// <summary>
    /// Amount of taxes that have been previously paid in relation to the taxable event.
    /// </summary>
    public IsoActiveCurrencyAndAmount? TaxCreditAmount { get; init; } 
    /// <summary>
    /// Amount of money withheld by the jurisdiction in which the income was originally paid, for which relief at source and/or reclaim may be possible.
    /// </summary>
    public IsoActiveCurrencyAndAmount? WithholdingOfForeignTaxAmount { get; init; } 
    /// <summary>
    /// Amount of money withheld by the jurisdiction in which the account owner is located, for which relief at source and/or reclaim may be possible.
    /// </summary>
    public IsoActiveCurrencyAndAmount? WithholdingOfLocalTaxAmount { get; init; } 
    /// <summary>
    /// Amount of additional taxes that cannot be categorised.
    /// </summary>
    public IsoActiveCurrencyAndAmount? AdditionalTaxAmount { get; init; } 
    /// <summary>
    /// Amount of a cash distribution that will be withheld by a tax authority.
    /// </summary>
    public IsoActiveCurrencyAndAmount? WithholdingTaxAmount { get; init; } 
    /// <summary>
    /// Amount of fiscal tax to apply.
    /// </summary>
    public IsoActiveCurrencyAndAmount? FiscalStampAmount { get; init; } 
    /// <summary>
    /// Amount of money paid to an executing broker as a commission.
    /// </summary>
    public IsoActiveCurrencyAndAmount? ExecutingBrokerAmount { get; init; } 
    /// <summary>
    /// Amount of paying/sub-paying agent commission.
    /// </summary>
    public IsoActiveCurrencyAndAmount? PayingAgentCommissionAmount { get; init; } 
    /// <summary>
    /// Local broker's commission.
    /// </summary>
    public IsoActiveCurrencyAndAmount? LocalBrokerCommissionAmount { get; init; } 
    /// <summary>
    /// Amount of money paid for delivery by regular post mail.
    /// </summary>
    public IsoActiveCurrencyAndAmount? PostageFeeAmount { get; init; } 
    /// <summary>
    /// Amount of money charged by a regulatory authority, for example, Securities and Exchange fees.
    /// </summary>
    public IsoActiveCurrencyAndAmount? RegulatoryFeesAmount { get; init; } 
    /// <summary>
    /// Amount of money (including insurance) paid for delivery by carrier.
    /// </summary>
    public IsoActiveCurrencyAndAmount? ShippingFeesAmount { get; init; } 
    /// <summary>
    /// Amount of money paid for the provision of financial services that cannot be categorised by another qualifier.
    /// </summary>
    public IsoActiveCurrencyAndAmount? ChargesAmount { get; init; } 
    /// <summary>
    /// Indicates cash retained from previous dividend.
    /// </summary>
    public IsoActiveCurrencyAndAmount? CashAmountBroughtForward { get; init; } 
    /// <summary>
    /// Indicates the balance carried forward to next dividend.
    /// </summary>
    public IsoActiveCurrencyAndAmount? CashAmountCarriedForward { get; init; } 
    /// <summary>
    /// Amount of cash that would have been payable if the dividend had been taken in the form of cash rather than shares.
    /// </summary>
    public IsoActiveCurrencyAndAmount? NotionalDividendPayableAmount { get; init; } 
    /// <summary>
    /// Where new securities are issued in lieu of a cash dividend, the notional tax is the tax on the amount of cash that would have been paid.
    /// </summary>
    public IsoActiveCurrencyAndAmount? NotionalTaxAmount { get; init; } 
    /// <summary>
    /// Amount of money paid by the Tax Authorities in addition to the payment of the tax refund itself.
    /// </summary>
    public IsoActiveCurrencyAndAmount? TaxArrearsAmount { get; init; } 
    /// <summary>
    /// Posting/settlement Amount in its original currency when conversion from/into another currency has occurred.
    /// </summary>
    public IsoActiveCurrencyAndAmount? OriginalAmount { get; init; } 
    /// <summary>
    /// Amount of money representing a distribution of a bond's principal, for example, repayment of outstanding debt.
    /// </summary>
    public IsoActiveCurrencyAndAmount? PrincipalOrCorpus { get; init; } 
    /// <summary>
    /// Amount of money (not interest) in addition to the principal at the redemption of a bond.
    /// </summary>
    public IsoActiveCurrencyAndAmount? RedemptionPremiumAmount { get; init; } 
    /// <summary>
    /// Amount relating to the underlying security for which income is distributed.
    /// </summary>
    public IsoActiveCurrencyAndAmount? IncomePortion { get; init; } 
    /// <summary>
    /// Amount of stock exchange tax.
    /// </summary>
    public IsoActiveCurrencyAndAmount? StockExchangeTax { get; init; } 
    /// <summary>
    /// Total amount of tax withheld at source in conformance with the EU Savings Directive.
    /// </summary>
    public IsoActiveCurrencyAndAmount? EUTaxRetentionAmount { get; init; } 
    /// <summary>
    /// Amount of interest that has been accrued in between coupon payment periods.
    /// </summary>
    public IsoActiveCurrencyAndAmount? AccruedInterestAmount { get; init; } 
    
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
        writer.WriteStartElement(null, "PstngAmt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(PostingAmount)); // data type ActiveCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
        if (GrossCashAmount is IsoActiveCurrencyAndAmount GrossCashAmountValue)
        {
            writer.WriteStartElement(null, "GrssCshAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(GrossCashAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (NetCashAmount is IsoActiveCurrencyAndAmount NetCashAmountValue)
        {
            writer.WriteStartElement(null, "NetCshAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(NetCashAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (SolicitationFees is IsoActiveCurrencyAndAmount SolicitationFeesValue)
        {
            writer.WriteStartElement(null, "SlctnFees", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(SolicitationFeesValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (CashInLieuOfShare is IsoActiveCurrencyAndAmount CashInLieuOfShareValue)
        {
            writer.WriteStartElement(null, "CshInLieuOfShr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(CashInLieuOfShareValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (CapitalGain is IsoActiveCurrencyAndAmount CapitalGainValue)
        {
            writer.WriteStartElement(null, "CptlGn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(CapitalGainValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (InterestAmount is IsoActiveCurrencyAndAmount InterestAmountValue)
        {
            writer.WriteStartElement(null, "IntrstAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(InterestAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (MarketClaimAmount is IsoActiveCurrencyAndAmount MarketClaimAmountValue)
        {
            writer.WriteStartElement(null, "MktClmAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(MarketClaimAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (IndemnityAmount is IsoActiveCurrencyAndAmount IndemnityAmountValue)
        {
            writer.WriteStartElement(null, "IndmntyAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(IndemnityAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (ManufacturedDividendPaymentAmount is IsoActiveCurrencyAndAmount ManufacturedDividendPaymentAmountValue)
        {
            writer.WriteStartElement(null, "ManfctrdDvddPmtAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(ManufacturedDividendPaymentAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (ReinvestmentAmount is IsoActiveCurrencyAndAmount ReinvestmentAmountValue)
        {
            writer.WriteStartElement(null, "RinvstmtAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(ReinvestmentAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (FullyFrankedAmount is IsoActiveCurrencyAndAmount FullyFrankedAmountValue)
        {
            writer.WriteStartElement(null, "FullyFrnkdAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(FullyFrankedAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (UnfrankedAmount is IsoActiveCurrencyAndAmount UnfrankedAmountValue)
        {
            writer.WriteStartElement(null, "UfrnkdAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(UnfrankedAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (SundryOrOtherAmount is IsoActiveCurrencyAndAmount SundryOrOtherAmountValue)
        {
            writer.WriteStartElement(null, "SndryOrOthrAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(SundryOrOtherAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (CashIncentive is IsoActiveCurrencyAndAmount CashIncentiveValue)
        {
            writer.WriteStartElement(null, "CshIncntiv", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(CashIncentiveValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (TaxFreeAmount is IsoActiveCurrencyAndAmount TaxFreeAmountValue)
        {
            writer.WriteStartElement(null, "TaxFreeAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(TaxFreeAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (TaxDeferredAmount is IsoActiveCurrencyAndAmount TaxDeferredAmountValue)
        {
            writer.WriteStartElement(null, "TaxDfrrdAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(TaxDeferredAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (ValueAddedTaxAmount is IsoActiveCurrencyAndAmount ValueAddedTaxAmountValue)
        {
            writer.WriteStartElement(null, "ValAddedTaxAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(ValueAddedTaxAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (StampDutyAmount is IsoActiveCurrencyAndAmount StampDutyAmountValue)
        {
            writer.WriteStartElement(null, "StmpDtyAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(StampDutyAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (TaxReclaimAmount is IsoActiveCurrencyAndAmount TaxReclaimAmountValue)
        {
            writer.WriteStartElement(null, "TaxRclmAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(TaxReclaimAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (TaxCreditAmount is IsoActiveCurrencyAndAmount TaxCreditAmountValue)
        {
            writer.WriteStartElement(null, "TaxCdtAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(TaxCreditAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (WithholdingOfForeignTaxAmount is IsoActiveCurrencyAndAmount WithholdingOfForeignTaxAmountValue)
        {
            writer.WriteStartElement(null, "WhldgOfFrgnTaxAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(WithholdingOfForeignTaxAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (WithholdingOfLocalTaxAmount is IsoActiveCurrencyAndAmount WithholdingOfLocalTaxAmountValue)
        {
            writer.WriteStartElement(null, "WhldgOfLclTaxAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(WithholdingOfLocalTaxAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (AdditionalTaxAmount is IsoActiveCurrencyAndAmount AdditionalTaxAmountValue)
        {
            writer.WriteStartElement(null, "AddtlTaxAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(AdditionalTaxAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (WithholdingTaxAmount is IsoActiveCurrencyAndAmount WithholdingTaxAmountValue)
        {
            writer.WriteStartElement(null, "WhldgTaxAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(WithholdingTaxAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (FiscalStampAmount is IsoActiveCurrencyAndAmount FiscalStampAmountValue)
        {
            writer.WriteStartElement(null, "FsclStmpAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(FiscalStampAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (ExecutingBrokerAmount is IsoActiveCurrencyAndAmount ExecutingBrokerAmountValue)
        {
            writer.WriteStartElement(null, "ExctgBrkrAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(ExecutingBrokerAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (PayingAgentCommissionAmount is IsoActiveCurrencyAndAmount PayingAgentCommissionAmountValue)
        {
            writer.WriteStartElement(null, "PngAgtComssnAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(PayingAgentCommissionAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (LocalBrokerCommissionAmount is IsoActiveCurrencyAndAmount LocalBrokerCommissionAmountValue)
        {
            writer.WriteStartElement(null, "LclBrkrComssnAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(LocalBrokerCommissionAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (PostageFeeAmount is IsoActiveCurrencyAndAmount PostageFeeAmountValue)
        {
            writer.WriteStartElement(null, "PstgFeeAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(PostageFeeAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (RegulatoryFeesAmount is IsoActiveCurrencyAndAmount RegulatoryFeesAmountValue)
        {
            writer.WriteStartElement(null, "RgltryFeesAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(RegulatoryFeesAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (ShippingFeesAmount is IsoActiveCurrencyAndAmount ShippingFeesAmountValue)
        {
            writer.WriteStartElement(null, "ShppgFeesAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(ShippingFeesAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (ChargesAmount is IsoActiveCurrencyAndAmount ChargesAmountValue)
        {
            writer.WriteStartElement(null, "ChrgsAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(ChargesAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (CashAmountBroughtForward is IsoActiveCurrencyAndAmount CashAmountBroughtForwardValue)
        {
            writer.WriteStartElement(null, "CshAmtBrghtFwd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(CashAmountBroughtForwardValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (CashAmountCarriedForward is IsoActiveCurrencyAndAmount CashAmountCarriedForwardValue)
        {
            writer.WriteStartElement(null, "CshAmtCrrdFwd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(CashAmountCarriedForwardValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (NotionalDividendPayableAmount is IsoActiveCurrencyAndAmount NotionalDividendPayableAmountValue)
        {
            writer.WriteStartElement(null, "NtnlDvddPyblAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(NotionalDividendPayableAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (NotionalTaxAmount is IsoActiveCurrencyAndAmount NotionalTaxAmountValue)
        {
            writer.WriteStartElement(null, "NtnlTaxAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(NotionalTaxAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (TaxArrearsAmount is IsoActiveCurrencyAndAmount TaxArrearsAmountValue)
        {
            writer.WriteStartElement(null, "TaxArrearsAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(TaxArrearsAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (OriginalAmount is IsoActiveCurrencyAndAmount OriginalAmountValue)
        {
            writer.WriteStartElement(null, "OrgnlAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(OriginalAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (PrincipalOrCorpus is IsoActiveCurrencyAndAmount PrincipalOrCorpusValue)
        {
            writer.WriteStartElement(null, "PrncplOrCrps", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(PrincipalOrCorpusValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (RedemptionPremiumAmount is IsoActiveCurrencyAndAmount RedemptionPremiumAmountValue)
        {
            writer.WriteStartElement(null, "RedPrmAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(RedemptionPremiumAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (IncomePortion is IsoActiveCurrencyAndAmount IncomePortionValue)
        {
            writer.WriteStartElement(null, "IncmPrtn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(IncomePortionValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (StockExchangeTax is IsoActiveCurrencyAndAmount StockExchangeTaxValue)
        {
            writer.WriteStartElement(null, "StockXchgTax", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(StockExchangeTaxValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (EUTaxRetentionAmount is IsoActiveCurrencyAndAmount EUTaxRetentionAmountValue)
        {
            writer.WriteStartElement(null, "EUTaxRtntnAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(EUTaxRetentionAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (AccruedInterestAmount is IsoActiveCurrencyAndAmount AccruedInterestAmountValue)
        {
            writer.WriteStartElement(null, "AcrdIntrstAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(AccruedInterestAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
    }
    public static CorporateActionAmounts11 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
