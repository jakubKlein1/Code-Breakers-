"""
You are given a positive ingeter. Your task is to return multiplicative persistence: https://en.wikipedia.org/wiki/Persistence_of_a_number.

Long story short: number of times you need to multiply the digits in a given number until you reach a single digit. Examples:

num = 10 
res = 1
explanation: 1•0 = 0, which is a single digit number

num = 963
res = 3
explanation: 9*6*3 = 162 -> 1*6*2 = 12 -> 1*2 = 2, which is a single digit number

Refer to the unit tests to grasp the idea of this task.
Feel free to add as many unit tests as you want.
No external dependencies!
"""
import unittest


def persistence_solution(number: int) -> int:
    """
    Returns persistence of a number
    """
    return 0


class PersistenceTestCase(unittest.TestCase):
    """
    Unit tests
    """

    def test(self):
        """
        Table-driven tests
        """
        testcases = [
            {
                "number": 5,
                "res": 0,
            },
            {
                "number": 999,
                "res": 4,
            },
        ]

        for case in testcases:
            res = persistence_solution(case["number"])
            self.assertEqual(
                res,
                case["res"],
                f'\nfailed test case "{case["number"]}": expected "{case["res"]}", but got "{res}".',
            )


if __name__ == "__main__":
    unittest.main()
