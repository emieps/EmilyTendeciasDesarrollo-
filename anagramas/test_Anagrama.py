from main as m
import pytest
@pytest.mark.parametrize(
    "s1,s2, expected",
    [
        ("roma","amor", True),
        ("emily", "emyli", True), 
        ("como", "hola", False), S
        ("calor", "lolo", True)
    ]
)

def test_ana(s1,s2, expected):
    assert check(s1,s2) == expected