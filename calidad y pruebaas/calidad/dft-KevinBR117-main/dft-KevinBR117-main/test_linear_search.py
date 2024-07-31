import linear_search
import unittest


class Test_linearSearch(unittest.TestCase):

    def test_linearSearch(self):
        cases = [
            ([5, 3, 5, 1, 9, 2, 4, 7, 8, 6, 12], 12, 10),
            ([5,7,8,6,3,0], 6, 3),
            ([],0, None),
            ([1,4,6,7], 0, None)
            
        ]

        for lista, elemento, expected in cases:
            with self.subTest(inp=lista, expected=expected):
                obtained = linear_search.LinearSearch(lista, elemento)
                self.assertEqual(obtained, expected,
                                "linearSearch(%s,%s) linearSearch should be %s" % (lista, elemento, expected))

if __name__ == '__main__':
    unittest.main()
