pragma solidity ^0.6.1;
pragma experimental ABIEncoderV2;

import "./IPoTypes.sol";

interface IWalletSeller
{
    // Contract setup
    function configure(string calldata sellerId, string calldata nameOfPurchasing, string calldata nameOfFunding) external;
    
    // Purchasing <= Seller Wallet
    function setPoItemAccepted(uint poNumber, uint8 poItemNumber, bytes32 soNumber, bytes32 soItemNumber) external;
    function setPoItemRejected(uint poNumber, uint8 poItemNumber) external;
    function setPoItemReadyForGoodsIssue(uint poNumber, uint8 poItemNumber) external;
    function setPoItemGoodsIssued(uint poNumber, uint8 poItemNumber) external;
    function setPoItemGoodsReceived(uint poNumber, uint8 poItemNumber) external;
}