#include <iostream>
using namespace std;

const string correct = "correct";
const string incorrect = "incorrect";
string validExpression(string& expression) {
	
	if (expression[0] == ')')
		return incorrect;

	for (size_t i = 0; i < expression.length(); ++i)
	{
		if (expression[i] == '(')
		{
			bool accept = false;
			for (size_t j = i + 1; j < expression.length(); ++j)
			{
				if (expression[j] == ')')
				{
					accept = true;
					expression.erase(j, 1);
					j = expression.length();
				}
			}

			if (!accept)
				return incorrect;
		}
		else
		{
			if (expression[i] == ')')
				return incorrect;

		}
	}
	return correct;
}

int main()
{
	string expression;
	while (cin >> expression)
	{
		cout << validExpression(expression) << endl;
	}

}

