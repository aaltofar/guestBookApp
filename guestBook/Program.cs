
using guestBook;

bool isFull = false;
Party.WelcomeMsg();


while (!isFull)
{
    Party.AskName();
    Party.AskSize();

    string cmd = Party.AskMore();
    if (cmd == "n")
    {
        isFull = true;
        break;
    }
}

Party.PartyOver();

