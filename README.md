# LCAPI
## The C# LendingClub API

LCAPI is a fully contained client for the [LendingClub API](https://www.lendingclub.com/developers/lc-api.action), in a [.NET Core](https://dotnet.github.io/) class library.

**This project is still in active development!** Do not use it for production services, managing your own account, or running a hedge fund. Not only is there no guarantee that this project is up-to-date with the current version of the LendingClub API, but there may be outstanding bugs in the library itself!

### Supported features
|Resource|Feature|Supported|
|------|--------------|-------------|
|[Account](https://www.lendingclub.com/developers/account-resource.action)|||
||[Summary](https://www.lendingclub.com/developers/summary.action)|Yes|
||[Available Cash](https://www.lendingclub.com/developers/available-cash.action)|Yes|
||[Transfer Funds](https://www.lendingclub.com/developers/add-funds.action)|Yes|
||[Pending Transfers](https://www.lendingclub.com/developers/pending-transfers.action)|Yes|
||Cancel transfers|**No**|
||Notes owned|**No**|
||Detailed notes owned|**No**|
||Portfolio owned|**No**|
||Create portfolio|**No**|
||Submit order|**No**|
|Loan|||
||Loan listing|**No**|
